using Microsoft.EntityFrameworkCore;
using Nojan.Data.Model;

namespace Nojan.Data.Commands
{
    public class InvoiceCommand : CommandBase
    {

        public CommandResponse<InvoiceModel> Create(InvoiceModel model)
        {
            var response = new CommandResponse<InvoiceModel>();
            try
            {
                using (MainDbContext)
                {
                    var lastInvoice = MainDbContext.Invoices.OrderByDescending(x => x.Id).FirstOrDefault();
                    model.Date = DateTime.Now;
                    model.Number = lastInvoice is null ? MainDbContext.SettingInvoice.FirstOrDefault()?.InitNumber : (int.Parse(lastInvoice.Number) + 1).ToString();
                    model.Customer = null;
                    MainDbContext.Invoices.Add(model);
                    MainDbContext.SaveChanges();

                    response.Data = model;
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse Delete(long id)
        {
            var response = new CommandResponse();
            try
            {
                using (MainDbContext)
                {
                    var entity = MainDbContext.Invoices.FirstOrDefault(x => x.Id == id);
                    if (entity is not null)
                        MainDbContext.Invoices.Remove(entity);
                    MainDbContext.SaveChanges();
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse<InvoiceItemModel> CreateItem(InvoiceItemModel model)
        {
            var response = new CommandResponse<InvoiceItemModel>();
            try
            {
                using (MainDbContext)
                {
                    var invoice = MainDbContext.Invoices.Include(x => x.Items).FirstOrDefault(x => x.Id == model.InvoiceId);
                    if (invoice is not null && !invoice.Items.Any(x => x.PriceListItemId == model.PriceListItemId))
                    {
                        invoice?.Items.Add(model);
                        MainDbContext.SaveChanges();
                    }

                    response.Data = model;
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse DeleteItem(long priceListItemId)
        {
            var response = new CommandResponse();
            try
            {
                using (MainDbContext)
                {
                    var entity = MainDbContext.InvoiceItems.FirstOrDefault(x => x.Id == priceListItemId);
                    if (entity is not null)
                        MainDbContext.InvoiceItems.Remove(entity);
                    MainDbContext.SaveChanges();
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse<InvoiceModel> FindById(long id)
        {
            var response = new CommandResponse<InvoiceModel>();
            try
            {
                using (MainDbContext)
                {
                    var invoice = MainDbContext.Invoices.Include(x => x.Customer).Include(x => x.Project).Include(x => x.Items).Include("Items.PriceListItem").FirstOrDefault(x => x.Id == id);
                    response.Data = invoice;
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse UpdateItem(InvoiceItemModel model)
        {
            var response = new CommandResponse();
            try
            {
                using (MainDbContext)
                {
                    var invoiceItem = MainDbContext.InvoiceItems.Find(model.Id);
                    if (invoiceItem is not null)
                    {
                        if (model.Qty != invoiceItem.Qty)
                            invoiceItem.Qty = model.Qty;
                        if (!string.IsNullOrEmpty(model.Unit) && !invoiceItem.Unit.Equals(model.Unit))
                            invoiceItem.Unit = model.Unit;

                        model.UpdateDateTime = DateTime.Now;
                        MainDbContext.SaveChanges();
                        response.IsSuccess = true;
                        return response;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse UpdateProject(InvoiceModel model)
        {
            var response = new CommandResponse();
            try
            {
                using (MainDbContext)
                {
                    var invoice = MainDbContext.Invoices.Find(model.Id);
                    if (invoice is not null)
                    {
                        invoice.ProjectId = model.ProjectId;
                        invoice.UpdateDateTime = DateTime.Now;
                        MainDbContext.SaveChanges();
                        response.IsSuccess = true;
                        return response;
                    }
                    else
                    {
                        response.IsSuccess = false;
                        return response;
                    }

                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse<List<InvoiceModel>> FindAllByCustomer(int customerId)
        {
            var response = new CommandResponse<List<InvoiceModel>>();
            try
            {
                using (MainDbContext)
                {
                    var invoices = MainDbContext.Invoices.Include(x => x.Project).Include(x => x.Items).Include("Items.PriceListItem").Where(x => x.CustomerId == customerId).ToList();
                    response.Data = invoices;
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }

        public CommandResponse<List<InvoiceModel>> FindAll()
        {
            var response = new CommandResponse<List<InvoiceModel>>();
            try
            {
                using (MainDbContext)
                {
                    var invoices = MainDbContext.Invoices.Include(x => x.Project).Include(x => x.Items).Include("Items.PriceListItem").ToList();
                    response.Data = invoices;
                    response.IsSuccess = true;
                    return response;
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.ToString();

                return response;
            }
        }
    }
}
