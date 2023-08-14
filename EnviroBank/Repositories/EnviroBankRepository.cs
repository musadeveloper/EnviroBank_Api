using EnviroBank.Data;
using EnviroBank.Helpers;
using EnviroBank.Models;
using Newtonsoft.Json;
using System.Security.Principal;

namespace EnviroBank.Repositories
{
    public class EnviroBankRepository
    {

        private readonly EnviroDbContext _context;
        private readonly IJwtHelper _jwtHelper;

        public EnviroBankRepository(EnviroDbContext context, IJwtHelper jwtHelper)
        {
            _context = context;
            _jwtHelper = jwtHelper;
        }

        public BaseResponse Login(Login login)
        {
            var response = new BaseResponse();

            try
            {
                var holder = _context.Holders.FirstOrDefault(holder => holder.EmailAddress == login.EmailAddress);

                if (holder == null)
                {
                    response.Message = "Account holder not found";
                }
                else
                {
                    if (holder.Password == login.Password)
                    {
                        var token = _jwtHelper.GenerateJwtToken(login.EmailAddress);

                        response.Success = true;
                        response.Message = "Login successful";
                        response.Result = token;
                    }
                    else
                    {
                        response.Message = "Invalid credentials";
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = "An error occurred: " + ex.Message;
            }

            return response;
        }

        public BaseResponse GetAccountsByHolder(int accountHolderId)
        {

            var response = new BaseResponse();

            try
            {
                var accounts = _context.Accounts.Where(account => account.AccountHolder == accountHolderId);

                if (accounts == null)
                {
                    response.Message = "Account not found";
                }
                else
                {
                    response.Success = true;
                    response.Result = JsonConvert.SerializeObject(accounts);
                }
            }
            catch (Exception ex)
            {
                response.Message = "An error occurred: " + ex.Message;
            }

            return response;
        }

        public BaseResponse GetAccountByAccountNumber(int accountNumber)
        {
            var response = new BaseResponse();

            try
            {
                var account = _context.Accounts.FirstOrDefault(account => account.AccountNumber == accountNumber);

                    if (account == null)
                    {
                        response.Message = "Account not found";
                    }
                    else
                    {
                        response.Success = true;
                        response.Result = JsonConvert.SerializeObject(account);
                    }
            }
            catch (Exception ex)
            {
                response.Message = "An error occurred: " + ex.Message;
            }

            return response;
        }

        public BaseResponse Withdraw(int accountNumber, decimal amount)
        {
            var response = new BaseResponse();

            try
            {
                var account = _context.Accounts.FirstOrDefault(account => account.AccountNumber == accountNumber);

                if (account == null)
                {
                    response.Message = "Account not found";
                    return response;
                }

                if (account.AccountStatus == "Inactive")
                {
                    response.Message = "Account inactive";
                    return response;
                }

                if (amount <= 0)
                {
                    response.Message = "Withdrawal amount must be greater than 0";
                    return response;
                }

                if (account.AvailableBalance < amount)
                {
                    response.Message = "Insufficient funds";
                    return response;
                }

                if (account.AccountType == "Savings" || account.AccountType == "Cheque")
                {
                    response.Message = "Cannot withdraw from a Savings or Cheque account";
                    return response;
                }

                account.AvailableBalance -= amount;

                var transaction = new Transaction
                {
                    AccountNumber = accountNumber,
                    Amount = -amount, 
                    Type = "Withdrawal",
                    TransactionDate = DateTime.Now
                };

                _context.Transactions.Add(transaction);
                _context.SaveChanges();

                response.Success = true;
                response.Message = "Withdrawal was successful";
            }
            catch (Exception ex)
            {
                response.Message = "An error occurred: " + ex.Message;
            }

            return response;
        }


    }
}
