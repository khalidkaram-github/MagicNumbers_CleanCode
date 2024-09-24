namespace MagicNumbers_CleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }


        #region Before
        public void AddItem(int quantity)
        {
            if (quantity > 1000) // الرقم السحري هنا
            {
                Console.WriteLine("تجاوز الحد الأقصى للكمية!");
            }
        }

        public void BookSeat(int numberOfSeats)
        {
            if (numberOfSeats > 5) // رقم سحري هنا
            {
                Console.WriteLine("لا يمكن حجز أكثر من 5 مقاعد!");
            }
        }

        public bool IsPasswordValid(string password)
        {
            return password.Length >= 8; // 8 هنا رقم سحري
        }
        #endregion

        //----------------------------------------------------------------------------------------------//

        #region After

        private const int MaxQuantity = 1000; // استخدام ثابت

        public void AddItemV2(int quantity)
        {
            if (quantity > MaxQuantity) // استخدام الثابت هنا
            {
                Console.WriteLine("تجاوز الحد الأقصى للكمية!");
            }
        }



        private const int MinPasswordLength = 8; // الحد الأدنى لطول كلمة السر

        public bool IsPasswordValidV2(string password)
        {
            return password.Length >= MinPasswordLength; // استخدام الثابت
        }



        private const int MaxSeatsPerBooking = 5; // الحد الأقصى للمقاعد المحجوزة

        public void BookSeatV2(int numberOfSeats)
        {
            if (numberOfSeats > MaxSeatsPerBooking) // استخدام الثابت هنا
            {
                Console.WriteLine("لا يمكن حجز أكثر من 5 مقاعد!");
            }
        }
    }
    #endregion

}
