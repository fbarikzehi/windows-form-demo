using Microsoft.EntityFrameworkCore;
using Nojan.Data.Model;
using Nojan.Shared.Utilities;

namespace Nojan.Data.Commands
{
    public class PriceListCommand : CommandBase
    {
        public CommandResponse<PriceListModel> Create(PriceListModel model)
        {
            var response = new CommandResponse<PriceListModel> { IsSuccess = true };
            try
            {
                if (string.IsNullOrEmpty(model.Title))
                {
                    response.IsSuccess = false;
                    response.Message = "مقدار عنوان را وارد کنید";
                }
                if (model.Year < DateTimeUtility.GetIntPersianYear(DateTime.Now) - 4 || model.Year > DateTimeUtility.GetIntPersianYear(DateTime.Now) + 1)
                {
                    response.IsSuccess = false;
                    response.Message = "مقدار سال را وارد کنید";
                }
                if (model.Month < 1 || model.Month > 12)
                {
                    response.IsSuccess = false;
                    response.Message = "بازه ماه نا معتبر وارد شده";
                }
                if (model.Items.Count == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "آیتم های لیست قیمت تعریف نشده";
                }
                if (!response.IsSuccess)
                    return response;


                using (MainDbContext)
                {
                    if (MainDbContext.PriceLists.Any(x => x.Title.Equals(model.Title)))
                    {
                        response.IsSuccess = false;
                        response.Message = "لیست قیمتی با این عنوان قبلا ثبت شده";
                        return response;
                    }
                    else
                    {
                        MainDbContext.PriceLists.Add(model);
                        MainDbContext.SaveChanges();

                        response.Data = model;
                        response.IsSuccess = true;
                        response.Message = "اطلاعات لیست قیمت با موفقیت ثبت شد";

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

        public CommandResponse<PriceListItemModel> CreateItem(PriceListItemModel model)
        {
            var response = new CommandResponse<PriceListItemModel> { IsSuccess = true };
            try
            {
                if (string.IsNullOrEmpty(model.Name))
                {
                    response.IsSuccess = false;
                    response.Message = "مقدار نام را وارد کنید";
                }
                if (model.Price <= 0)
                {
                    response.IsSuccess = false;
                    response.Message = "مقدار قیمت را وارد کنید";
                }
                if (!response.IsSuccess)
                    return response;


                using (MainDbContext)
                {
                    if (!MainDbContext.PriceLists.Any(x => x.Id == model.PriceList.Id))
                    {
                        response.IsSuccess = false;
                        response.Message = "لیست قیمت در سیستم ثبت نشده";
                        return response;
                    }
                    if (model.Code == 0)
                        model.Code = MainDbContext.PriceListItems.Any() ? MainDbContext.PriceListItems.OrderByDescending(x => x.Id).FirstOrDefault().Code + 1 : 1000;
                    var priceList = MainDbContext.PriceLists.Include(x => x.Items).FirstOrDefault(x => x.Id == model.PriceList.Id);
                    priceList?.Items.Add(model);
                    MainDbContext.SaveChanges();

                    response.Data = model;
                    response.IsSuccess = true;
                    response.Message = "اطلاعات آیتم با موفقیت ثبت شد";

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

        public CommandResponse DeleteItems(List<PriceListItemModel> model)
        {
            var response = new CommandResponse();
            try
            {
                using (MainDbContext)
                {
                    PriceListItemModel? entity = null;
                    foreach (var item in model)
                    {
                        entity = MainDbContext.PriceListItems.Find(item.Id);
                        if (entity is not null)
                            MainDbContext.PriceListItems.Remove(entity);
                    }
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

        public CommandResponse<List<PriceListModel>> FindAll()
        {
            var response = new CommandResponse<List<PriceListModel>>();
            try
            {
                using (MainDbContext)
                {
                    response.Data = MainDbContext.PriceLists.Include(x => x.Items).Select(x => new PriceListModel
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Year = x.Year,
                        Month = x.Month,
                        Items = x.Items.Select(item => new PriceListItemModel
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Price = item.Price,
                            Code = item.Code,
                        }).ToList(),
                    }).ToList();
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

        public CommandResponse<List<PriceListModel>> FindAllWithoutItems()
        {
            var response = new CommandResponse<List<PriceListModel>>();
            try
            {
                using (MainDbContext)
                {
                    response.Data = MainDbContext.PriceLists.Select(x => new PriceListModel
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Year = x.Year,
                        Month = x.Month,
                    }).ToList();
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

        public CommandResponse<List<PriceListItemModel>> FindAllItemsByPriceList(int priceListId)
        {
            var response = new CommandResponse<List<PriceListItemModel>>();
            try
            {
                using (MainDbContext)
                {
                    response.Data = MainDbContext.PriceLists.Include(x => x.Items).FirstOrDefault(x => x.Id == priceListId)?.Items.Select(x => new PriceListItemModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Price = x.Price,
                        Code = x.Code,
                        CreateDateTime = x.CreateDateTime,
                    }).ToList();
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
