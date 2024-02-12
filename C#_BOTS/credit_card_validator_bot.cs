using System.ComponentModel.Design;
using Telegram.Bot;
using Telegram.Bot.Types;


namespace telegramBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("YOUR_TELEGRAM_BOT_API_TOKEN_HERE");

            client.StartReceiving(Update, Error, null);

            Console.ReadLine();
        }


        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
            //HERE YOU CAN HANDLE ANY EXCEPTIONS
        }

        async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;

            if (message.Text != null)
            {
                Console.WriteLine($"USER ID:  {message.Chat.FirstName}, {message.Chat.LastName}, {message.Chat.Username}\tMESSAGE:  {message.Text}");
                //HERE YOU CAN ADD SQL DATABASE QUERY TO ADD OR UPDATE USER INFORMATION IF NEEDED OR ADD USER REQUESTSI IN DATABASE

                if (message.Text == "/start")
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Hello This Bot is for Checking and Validating VISA CARD numbers!");
                }

                else
                {
                    string credit_card_number = message.Text;
                    int sumOddDigits = 0;
                    int sumEvenDigits = 0;
                    char[] cardNumberArray = credit_card_number.ToCharArray();

                    Array.Reverse(cardNumberArray);
                    string reversedCardNumber = new string(cardNumberArray);

                    for (int i = 0; i < reversedCardNumber.Length; i += 2)
                    { sumOddDigits += int.Parse(reversedCardNumber[i].ToString()); }

                    for (int i = 1; i < reversedCardNumber.Length; i += 2)
                    {
                        int x = int.Parse(reversedCardNumber[i].ToString()) * 2;
                        if (x >= 10) { sumEvenDigits += 1 + (x % 10); }
                        else { sumEvenDigits += x; }
                    }

                    int total = sumOddDigits + sumEvenDigits;
                    if (total % 10 == 0)
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, $"{message.Text} credit card number is VALID!");
                        return;
                    }
                    else
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, $"{message.Text} credit card number is INVALID!");
                        return;
                    }
                }               
            }
        }
    }
}
