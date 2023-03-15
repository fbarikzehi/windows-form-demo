using Microsoft.EntityFrameworkCore;
using Nojan.Data.Model;

namespace Nojan.Data.Commands
{
    public class CustomerCommand : CommandBase
    {

        public CommandResponse<CustomerModel> Create(CustomerModel model)
        {
            var response = new CommandResponse<CustomerModel>();
            try
            {
                if (string.IsNullOrEmpty(model.FullName))
                {
                    response.IsSuccess = false;
                    response.Message = "نام و نام خانوادگی را وارد کنید ";

                    return response;
                }

                if (!string.IsNullOrEmpty(model.Phone) && model.Phone.Length > 11 && model.Phone.Length < 8)
                {
                    response.IsSuccess = false;
                    response.Message = "تلفن را یکی از این فرمت ها وارد کنید (03531234567-31234567) ";

                    return response;
                }


                if (!string.IsNullOrEmpty(model.Mobile) && model.Mobile.Length != 11)
                {
                    response.IsSuccess = false;
                    response.Message = "تلفن همراه را فرمت 11 رقم وارد کنید";

                    return response;
                }

                using (MainDbContext)
                {
                    if (MainDbContext.Customers.Any(x => x.FullName.Equals(model.FullName)))
                    {
                        response.IsSuccess = false;
                        response.Message = "مشتری با این نام قبلا ثبت شده";

                        return response;
                    }
                    else
                    {
                        var lastCustomer = MainDbContext.Customers.OrderByDescending(x => x.Id).FirstOrDefault();
                        model.Code = lastCustomer != null ? lastCustomer.Code + 1 : 1000;

                        MainDbContext.Customers.Add(model);
                        MainDbContext.SaveChanges();

                        response.Data = model;
                        response.IsSuccess = true;
                        response.Message = "اطلاعات مشتری با موفقیت ثبت شد";

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

        public CommandResponse<CustomerProjectModel> AddProject(CustomerProjectModel model)
        {
            var response = new CommandResponse<CustomerProjectModel>();
            try
            {
                if (model.CustomerId == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "خطا در بارگیری اطلاعات مشتری ";

                    return response;
                }

                if (string.IsNullOrEmpty(model.Title))
                {
                    response.IsSuccess = false;
                    response.Message = "عنوان پروژه وارد کنید";

                    return response;
                }

                using (MainDbContext)
                {
                    if (MainDbContext.CustomerProjects.Any(x => x.Title.Equals(model.Title)))
                    {
                        response.IsSuccess = false;
                        response.Message = "پروژه ای با این عنوان قبلا ثبت شده";

                        return response;
                    }
                    else
                    {
                        MainDbContext.CustomerProjects.Add(model);
                        MainDbContext.SaveChanges();

                        response.Data = model;
                        response.IsSuccess = true;
                        response.Message = "اطلاعات پروژه با موفقیت ثبت شد";

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



        public CommandResponse<Dictionary<int, string>> GetProjects(int customerId)
        {
            var response = new CommandResponse<Dictionary<int, string>>();
            try
            {
                using (MainDbContext)
                {
                    if (MainDbContext.CustomerProjects.Any(x => x.CustomerId == customerId))
                        response.Data = MainDbContext.CustomerProjects.Where(x => x.CustomerId == customerId).Select(x => new { Id = x.Id, Name = x.Title }).ToDictionary(x => x.Id, x => x.Name);
                    else
                        response.Data = new Dictionary<int, string>();
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
