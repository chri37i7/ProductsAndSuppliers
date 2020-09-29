using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductsAndSuppliers.Utilities
{
    /// <summary>
    /// Class containing static validation methods used for encapsulating classes.
    /// </summary>
    public static class Validations
    {
        /// <summary>
        /// Validates if the input string is null, or empty. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIsStringNull(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return (false, "The value cannot be null, or empty");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input string is null, or empty. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIsStringNullAsync(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return Task.FromResult((false, "The value cannot be null, or empty"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input integer is negative. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIsIntNegative(int number)
        {
            if(number < 0)
            {
                return (false, "The number cannot be lower than 0");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input integer is negative. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIsIntNegativeAsync(int number)
        {
            if(number < 0)
            {
                return Task.FromResult((false, "The number cannot be lower than 0"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input <see cref="DateTime"/> is before or after <see cref="DateTime.Now"/>. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static (bool, string) ValidateDateTime(DateTime date)
        {
            if(date.Year < (DateTime.Now.Year - 100))
            {
                return (false, $"The value cannot be before {(DateTime.Now.Year - 100)}");
            }
            else if(date.Year > (DateTime.Now.Year + 100))
            {
                return (false, $"The value cannot be before {(DateTime.Now.Year + 100)}");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input <see cref="DateTime"/> is before or after <see cref="DateTime.Now"/>. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateDateTimeAsync(DateTime date)
        {
            if(date.Year < (DateTime.Now.Year - 100))
            {
                return Task.FromResult((false, $"The value cannot be before {(DateTime.Now.Year - 100)}"));
            }
            else if(date.Year > (DateTime.Now.Year + 100))
            {
                return Task.FromResult((false, $"The value cannot be after {(DateTime.Now.Year + 100)}"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input string is a valid IPv4 address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static (bool, string) ValidateAddress(string address)
        {
            if(string.IsNullOrWhiteSpace(address))
            {
                return (false, "The value cannot be null, empty, or whitespaces");
            }
            string ipRange = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            if(!Regex.IsMatch(address, ipRange))
            {
                return (false, "The value is not a valid IPv4 address");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input string is a valid IPv4 address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateAddressAsync(string address)
        {
            if(string.IsNullOrWhiteSpace(address))
            {
                return Task.FromResult((false, "The value cannot be null, empty, or whitespaces"));
            }
            string ipRange = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            if(!Regex.IsMatch(address, ipRange))
            {
                return Task.FromResult((false, "The value is not a valid IPv4 address"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input ushort is within the 27000 - 28000 port range
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static (bool, string) ValidatePort(ushort port)
        {
            if(port > 28000)
            {
                return (false, "The value cannot be above 28000");
            }
            if(port < 27000)
            {
                return (false, "The value cannot be below 27000");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input ushort is within the 27000 - 28000 port range
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidatePortAsync(ushort port)
        {
            if(port > 28000)
            {
                return Task.FromResult((false, "The value cannot be above 28000"));
            }
            if(port < 27000)
            {
                return Task.FromResult((false, "The value cannot be below 27000"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input string array is empty. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIsStringArrayEmpty(string[] names)
        {
            if(names.Length < 1)
            {
                return (false, "The value cannot contain nothing");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input string array is empty. Returns <see langword="false"/> if so.
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIsStringArrayEmptyAsync(string[] names)
        {
            if(names.Length < 1)
            {
                return Task.FromResult((false, "The value cannot be empty"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the value has 18 digits. Returns <see langword="false"/> is not.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static (bool, string) ValidateDiscordId(ulong id)
        {
            if(id.ToString().Length != 18)
            {
                return (false, "The lenght of the value cannot be longer, or shorter than 18 digits");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the value has 18 digits. Returns <see langword="false"/> is not.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateDiscordIdAsync(ulong id)
        {
            if(id.ToString().Length != 18)
            {
                return Task.FromResult((false, "The lenght of the value cannot be longer, or shorter than 18 digits"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the ulong is negative, returns <see langword="false"/> if so
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIsUlongNegative(ulong number)
        {
            if(number < 0)
            {
                return (false, "The value cannot be lower than 0");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the ulong is negative, returns <see langword="false"/> if so
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIsUlongNegativeAsync(ulong number)
        {
            if(number < 0)
            {
                return Task.FromResult((false, "The value cannot be lower than 0"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the double is negative, returns <see langword="false"/> if so
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIsNullableDoubleNegative(double? number)
        {
            if(number < 0)
            {
                return (false, "The value cannot be lower than 0");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the double is negative, returns <see langword="false"/> if so
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIsNullableDoubleNegativeAsync(double? number)
        {
            if(number < 0)
            {
                return Task.FromResult((false, "The value cannot be lower than 0"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input is a valid unix timestamp
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static (bool, string) ValidateUnixTimestamp(int timestamp)
        {
            if(timestamp.ToString().Length != 10)
            {
                return (false, "The value cannot be cannot be lower, or higher than 10 digits.");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input is a valid unix timestamp
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateUnixTimestampAsync(int timestamp)
        {
            if(timestamp.ToString().Length != 10)
            {
                return Task.FromResult((false, "The value cannot be cannot be lower, or higher than 10 digits."));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input is a valid IPv4 address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static (bool, string) ValidateIpAddress(string address)
        {
            if(!Regex.IsMatch(address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
            {
                return (false, "The value is not a valid IPv4 Address");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input is a valid IPv4 address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateIpAddressAsync(string address)
        {
            if(!Regex.IsMatch(address, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"))
            {
                return Task.FromResult((false, "The value is not a valid IPv4 Address"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }

        /// <summary>
        /// Validates if the input is a valid Steam32ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static (bool, string) ValidateSteamId(string id)
        {
            if(!Regex.IsMatch(id, @"^STEAM_[0-5]:[0-1]:\d+"))
            {
                return (false, "The value is not a valid Steam32ID");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        /// <summary>
        /// Validates if the input is a valid Steam32ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Task<(bool, string)> ValidateSteamIdAsync(string id)
        {
            if(!Regex.IsMatch(id, @"^STEAM_[0-5]:[0-1]:\d+"))
            {
                return Task.FromResult((false, "The value is not a valid Steam32ID"));
            }
            else
            {
                return Task.FromResult((true, string.Empty));
            }
        }
    }
}
