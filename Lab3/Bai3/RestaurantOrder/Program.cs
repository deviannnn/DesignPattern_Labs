using RestaurantOrder;

public class Program
{
    /*
     * Mô tả:
        - Hệ thống Nhà Hàng Ảo: Đây là một hệ thống đơn giản để người dùng có thể chọn 
        và đặt món ăn từ một danh sách các món trong một nhà hàng ảo.

        - Lựa chọn Món Ăn: Người dùng có thể chọn giữa hai loại món chính là Pasta và Steak.
        Mỗi loại món lại có các tùy chọn cụ thể.

        - Tuỳ chỉnh Món Ăn: Người dùng có thể tùy chỉnh món ăn theo sở thích cá nhân, 
        ví dụ: lựa chọn loại pasta, nấu chín thịt theo mức độ mong muốn.

        - Ghi chú Đặt Hàng: Người dùng có thể để lại ghi chú đặt hàng để yêu cầu hoặc ghi chú riêng về món ăn.

        - Xác nhận Đặt Hàng: Hệ thống yêu cầu xác nhận từ người dùng sau khi họ đã chọn món và nhập ghi chú.
        Nếu người dùng xác nhận, đơn hàng sẽ được gửi đến bếp để chuẩn bị.

        - Hiển thị Trạng thái Chuẩn bị: Hệ thống thông báo cho người dùng về trạng thái chuẩn bị của đơn hàng,
        ví dụ như "Đã gửi đơn hàng tới bếp", "Bếp đang chuẩn bị món",...
    
     * Vấn đề:
        - Các món ăn sẽ có các phương thức được định nghĩa khác nhau như ChooseDish(), SpecifyCustomizations() và CookDish()
        
        . ChooseDish()  
            . Trong thực tế: Mô phỏng cho việc chọn món ăn cụ thể để hiện thị cửa sổ chi tiết về món ăn đó,
                             hiện thị form tùy chọn về món ăn đó,...
            . Trong chương trình: In tên món ăn được chọn.

        . SpecifyCustomizations()
            . Trong thực tế: Mô phỏng cho việc khách hàng tùy chọn về món ăn đó vì mỗi ăn khác nhau sẽ có
                             các tùy chọn khác nhau.
            . Trong chương trình: In các tùy chọn của món ăn được chọn.

        . CookDish()
            . Trong thực tế: Mô phỏng cho việc thông báo món ăn đang được nấu cũng như thực hiện trừ đi số lượng nguyên liệu
                             trong csdl của món ăn đó.
            . Trong chương trình: In thông báo món ăn đang được nấu.

        - Còn lại là các phương thức NoteOrder() và ConfirmOrder() mô phỏng việc ghi chú cho món ăn cụ thể và xác nhận order cho món ăn đó.
          Và đây là 2 phương thức dùng cho tất cả món ăn
     */
    public static DishesOrderType currentDishOrder;
    static void Main(string[] args)
    {
        SimpleRestaurantFactory factory = new SimpleRestaurantFactory();
        Restaurant test = new Restaurant(factory);

        bool continueOrdering = true;
        while (continueOrdering)
        {
            Console.WriteLine("\nChoose Dishes: ");
            Console.WriteLine("    a. Pasta");
            Console.WriteLine("    b. Steak");
            Console.WriteLine("    _. Done");

            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "a":
                    currentDishOrder = DishesOrderType.Pasta;
                    break;

                case "b":
                    currentDishOrder = DishesOrderType.Steak;
                    break;

                default:
                    continueOrdering = false;
                    break;
            }

            if (continueOrdering)
            {
                test.OrderSomeDishes(currentDishOrder);
            }
        }
        Console.WriteLine("Thank you for ordering.");
    }
}
