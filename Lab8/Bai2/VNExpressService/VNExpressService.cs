using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNExpressService
{
    public class VECat
    {
        public int CatId { get; set; }
        public string Title { get; set; }
    }

    public class VENews
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
    }

    public class VNExpressService
    {
        public static VECat[] AllCategories => new VECat[]
        {
            new VECat { CatId = 1, Title = "Văn hóa" },
            new VECat { CatId = 2, Title = "Giải trí" },
            new VECat { CatId = 3, Title = "Bóng đá" },
            new VECat { CatId = 4, Title = "Công nghệ" },
            new VECat { CatId = 5, Title = "Kinh Doanh" }
        };

        public static VENews[] AllNews => new VENews[]
        {
            new VENews
            {
                Id = 1,
                Headline = "Ngày sách và văn hóa đọc 2024: Kêu gọi đẩy lùi sách giả, sách lậu",
                Content = "Chào mừng Ngày sách và văn hóa đọc Việt Nam (21.4), Ngày sách và bản quyền thế giới (23.4), chiều 15.4, Sở TT - TT TP.HCM đã họp báo giới thiệu nhiều sự kiện trong 5 ngày diễn ra.\r\nNgày sách và văn hóa đọc Việt Nam lần 3 diễn ra từ 17 - 22.4, với hơn 300 hoạt động được tổ chức tại Thủ Đức và 21 quận, huyện, tăng 50% so với năm 2023. Không gian năm nay được thiết kế theo chủ đề Mở cửa trí thức, trải dài từ Công trường Công xã Paris đến đường sách Nguyễn Văn Bình (Q.1, TP.HCM).\r\n\r\nNhà văn Nguyễn Nhật Ánh sẽ là đại sứ năm nay. Từ thông điệp Tặng sách hay, mua sách thật của chuỗi các sự kiện, ông sẽ cùng các đại sứ kêu gọi đẩy lùi sách giả, sách lậu và khuyến khích có thêm tác phẩm dành cho thiếu nhi.",
                CategoryId = 1
            },
            new VENews
            {
                Id = 2,
                Headline = "Em trai bán xe, đưa vàng cho Ngọc Sơn đi hát",
                Content = "Để giúp Ngọc Sơn có cơ hội được đứng trên sân khấu, Ngọc Hải đã bán chiếc xe đạp của mình trị giá 5 phân vàng và dùng số tiền này sắm sửa quần áo mới cho anh trai.\r\n\r\nSau thời gian ấp ủ, Ngọc Sơn cho ra mắt MV kết hợp với em trai Ngọc Hải mang tên Thương người nông dân. Ca khúc này chính là tấm lòng của hai anh em Ngọc Sơn gửi đến những người nông dân lam lũ, chịu thương chịu khó.\r\n\r\nBên cạnh đó, sản phẩm âm nhạc này cũng là đánh dấu màn kết hợp của anh em Ngọc Sơn sau 20 năm. Được biết, vào những năm 1990 Ngọc Hải từng là giọng ca được nhiều khán giả yêu mến nhưng cuối cùng anh lựa chọn con đường kinh doanh thay vì theo nghệ thuật. Dù tiếc nuối nhưng giọng ca Tình cha vẫn tôn trọng quyết định của Ngọc Hải, đồng thời, anh luôn thể hiện sự tự hào về những thành tựu mà em trai mình đạt được.\r\n\r\n",
                CategoryId = 2
            },
            new VENews
            {
                Id = 3,
                Headline = "Ronaldo đăng thông điệp đầy ẩn ý trước nguy cơ bị phạt rất nặng",
                Content = "Ngày 13.4, Cristiano Ronaldo đăng thông điệp ngắn gọn: 'Trở lại làm việc', giữa thông tin anh sắp bị Liên đoàn Bóng đá Ả Rập Xê Út cấm thi đấu 2 trận và phạt tiền.\r\nRonaldo đối mặt án phạt nặng do nhận chiếc thẻ đỏ trực tiếp trong trận CLB Al Nassr thua kình địch Al Hilal với tỷ số 1-2 tại bán kết giải Siêu cúp Ả Rập Xê Út ngày 9.4. Bên cạnh hành vi thúc cùi chỏ vào đối thủ khiến phải nhận án thẻ phạt, danh thủ người Bồ Đào Nha còn có hành động đe dọa trọng tài.\r\n\r\n\"Liên đoàn Bóng đá Ả Rập Xê Út đã đề nghị CLB Al Nassr phải giải trình về các hành động của Ronaldo trước ngày 13.4 tuần này, thông qua những gì trọng tài Mohammed Al Huwaish viết trong báo cáo sau trận đấu. Khả năng lớn, Ronaldo sẽ bị cấm thi đấu 2 trận và nộp phạt một khoản tiền lớn vì các hành vi của mình. Tuy nhiên, cho đến hết tuần này, án phạt chưa được công bố, mà có thể chỉ được thông báo chính thức vào đầu tuần sau\", tờ Marca (Tây Ban Nha) cho biết.\r\n\r\nTheo tờ Marca: \"Trong báo cáo, trọng tài Mohammed Al Huwaish đã chỉ trích các hành động đe dọa của Ronaldo là đáng hổ thẹn, và là một vết nhơ cho bóng đá Ả Rập Xê Út\".",
                CategoryId = 3
            },
            new VENews
            {
                Id = 4,
                Headline = "Bước ngoặt cuộc đua vô địch giải Ngoại hạng Anh, điều gì đang xảy ra?",
                Content = "Cuộc đua 'tam mã' giữa Man City, Liverpool và Arsenal tranh ngôi vô địch giải Ngoại hạng Anh mùa 2023 - 2024 đã có bước ngoặt lớn ngay trước 6 vòng đấu còn lại. 'Man xanh' đang nắm ưu thế, nhưng bất ngờ vẫn có thể xảy ra.\r\nỞ vòng 33 giải Ngoại hạng Anh (chỉ còn trận Chelsea gặp Everton lúc 2 giờ ngày 16.4), Liverpool và Arsenal cùng nhận thất bại cay đắng ở sân nhà lần lượt trước Crystal Palace với tỷ số 0-1 và Aston Villa tỷ số 0-2. \r\n\r\nTrong khi trước đó, Man City thắng Luton Town tỷ số 5-1. Các kết quả này làm thay đổi vị trí trên bảng xếp hạng, khi đội quân của HLV Pep Guardiola chính thức chiếm ngôi đầu với 73 điểm, Arsenal và Liverpool có cùng 71 điểm xếp ngay sau. Trong đó, \"Pháo thủ\" xếp nhì bảng nhờ hơn hiệu số.",
                CategoryId = 3
            },
            new VENews
            {
                Id = 5,
                Headline = "Doanh số iPhone giảm mạnh trong khi thị trường smartphone toàn cầu phục hồi",
                Content = "Báo cáo mới nhất từ IDC cho biết trong quý 1/2024, doanh số iPhone đã giảm 9,6% trên toàn cầu bất chấp toàn bộ ngành công nghiệp smartphone đã phục hồi.\r\nTheo PhoneArena, trong quý 1/2024, doanh số smartphone toàn cầu tăng 7,8% so với cùng kỳ năm ngoái, lên 289,4 triệu chiếc. Apple chỉ bán ra 50,1 triệu chiếc iPhone trong khoảng thời gian này, xếp ở vị trí thứ hai với 17,3% thị phần.\r\nỞ vị trí dẫn đầu là Samsung với dòng sản phẩm chủ lực Galaxy S24 trang bị các tính năng Galaxy AI đã giúp công ty xuất xưởng 60,1 triệu smartphone. Mặc dù con số này giảm 0,7% so với cùng kỳ năm ngoái nhưng nó vẫn giúp Samsung có thị phần dẫn đầu ngành là 20,8%. Nhờ doanh số bán hàng tăng 33,8%, Xiaomi ở vị trí thứ ba với 14,1% thị phần sau khi xuất xưởng tổng cộng 40,8 triệu smartphone trong ba tháng đầu năm.\r\n\r\nNhà sản xuất smartphone có mức tăng trưởng nhanh nhất trong quý 1 là Transsion (Trung Quốc) với mức tăng vọt 84,9% lên 28,5 triệu điện thoại bán ra, chiếm 10% thị phần toàn cầu và ở vị trí thứ tư. Các smartphone đến từ Transsion được bán ở các quốc gia châu Phi, Trung Đông, Đông Nam Á, Nam Á và châu Mỹ Latin. Ở vị trí thứ năm là Oppo khi bán ra 25,2 triệu smartphone trong quý 1, chiếm 8,7% thị phần.",
                CategoryId = 4
            },
            new VENews
            {
                Id = 6,
                Headline = "iPhone 17 Pro sẽ trang bị chip 2nm do TSMC sản xuất",
                Content = "iPhone 17 Pro có thể sẽ là điện thoại thông minh đầu tiên chạy trên chip 2nm do TSMC sản xuất.\r\nTheo TechSpot, thế hệ iPhone 17 dự kiến ra mắt vào năm 2025, tuy nhiên, những thông tin về dòng điện thoại này đã thu hút sự chú ý của giới công nghệ, đặc biệt là khả năng sử dụng chip 2nm do TSMC sản xuất.\r\n\r\nTheo dự đoán, iPhone 17 Pro và iPhone 17 Pro Max sẽ là những điện thoại đầu tiên trang bị chip xử lý 2nm, được gọi là \"N2\". Chip này được sản xuất bởi TSMC, dự kiến đi vào sản xuất thử nghiệm vào cuối năm nay và chính thức sản xuất hàng loạt vào năm 2025. Với tên gọi A19 Pro, chip 2nm hứa hẹn mang đến hiệu năng vượt trội và tiết kiệm điện năng hơn so với các thế hệ chip trước.",
                CategoryId = 4
            },
            new VENews
            {
                Id = 7,
                Headline = "Giá vàng hôm nay 15.4.2024: Giá mua vào tăng mạnh",
                Content = "Giá vàng trong và ngoài nước đồng loạt tăng giá. Một điểm đáng chú ý trên thị trường là các đơn vị kinh doanh vàng tăng mạnh giá mua vào so với giá bán ra.\r\nGiá vàng miếng SJC tăng 300.000 - 600.000 đồng mỗi lượng, trong đó giá mua có chiều hướng tăng mạnh hơn bán ra. Công ty vàng bạc đá quý Sài Gòn - SJC mua vào lên 81,2 triệu đồng, bán ra 83,4 triệu đồng. Eximbank mua vào 81,5 triệu đồng, bán ra 83,5 triệu đồng. Công ty CP vàng bạc đá quý Phú Nhuận (PNJ) mua vào 81,2 triệu đồng, bán ra 83,4 triệu đồng… Giá vàng miếng SJC cao hơn nhẵn 7 triệu đồng/lượng.\r\n\r\nGiá vàng nhẫn tăng từ 100.000 - 200.000 đồng mỗi lượng. Công ty PNJ mua vào lên 74,5 triệu đồng, bán ra 76,3 triệu đồng; SJC mua vào 74,4 triệu đồng, bán ra 76,4 triệu đồng… Giá mua và bán vàng trong nước hiện đang có mức chênh lệch khoảng 2 triệu đồng/lượng. Giá vàng miếng SJC cao hơn thế giới 12 triệu đồng/lượng, vàng nhẫn cao hơn 5 triệu đồng/lượng.\r\n\r\nTăng mạnh chiều mua vào là động thái ngược lại với trước đây, các đơn vị kinh doanh vàng thường tăng giá bán ra nhưng giảm giá mua vào. Trong bối cảnh thị trường đang chờ thông tin chính thức về cung vàng từ Ngân hàng Nhà nước trong tuyên bố cuối tuần trước, nhiều ý kiến cho rằng, đây là cơ hội chốt lời tốt để tránh một đợt rớt mạnh có thể xảy ra trong tương lai gần.",
                CategoryId = 5
            },
        };

        public VECat[] RetriveCats()
        {
            return AllCategories;
        }

        public VENews[] RetriveNews(int categoryId)
        {
            if (categoryId > 0)
            {
                var newsInCategory = AllNews.Where(news => news.CategoryId == categoryId).ToArray();
                return newsInCategory.Any() ? newsInCategory : new VENews[0];
            }
            else
            {
                return AllNews.Take(6).ToArray();
            }
        }

        public VENews RetriveNewsById(int newsId)
        {
            return AllNews.FirstOrDefault(news => news.Id == newsId);
        }
    }
}
