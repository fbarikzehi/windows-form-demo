using Nojan.Data.Model;

namespace Nojan.Data.Commands
{
    public class SettingInvoiceCommand : CommandBase
    {
        public CommandResponse<SettingInvoiceModel> Find()
        {
            var response = new CommandResponse<SettingInvoiceModel>();
            try
            {
                using (MainDbContext)
                {
                    response.Data = MainDbContext.SettingInvoice.FirstOrDefault();
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
