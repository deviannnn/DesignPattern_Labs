using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNienService
{
    public class TNCat
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class TNNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
    }

    public class ThanhNienService
    {
        public static List<TNCat> AllCategories => new List<TNCat>
        {
            new TNCat { Id = 1, Title = "Kinh tế" },
            new TNCat { Id = 2, Title = "Đời sống" },
            new TNCat { Id = 3, Title = "Sức khỏe" },
            new TNCat { Id = 4, Title = "Giáo dục" }
        };
            
        public static List<TNNews> AllNews => new List<TNNews>
        {
            new TNNews
            {
                Id = 1,
                Title = "4 lý do khiến giá vé máy bay 'leo thang'",
                Content = "Tại buổi làm việc với Cục Hàng không Việt Nam mới đây, ông Subhas Menon, Giám đốc điều hành Hiệp hội các hãng hàng không châu Á - Thái Bình Dương (AAPA), cho biết giá vé máy bay trên thế giới hiện nay và trong thời gian tới sẽ có xu hướng tăng cao hơn so với trước.Theo AAPA, có 4 nguyên nhân chính dẫn đến tình trạng này:\r\n\r\nThứ nhất, tình trạng thiếu hụt tàu bay trên diện rộng xảy ra với các hãng hàng không trên thế giới sẽ tiếp diễn trong bối cảnh việc thuê, mua để bù đắp lượng thiếu hụt chưa thể thực hiện tức thì. Nguyên nhân, do 2 nhà sản xuất tàu bay hàng đầu trên thế giới là Airbus và Boeing đều đang phải xử lý các vấn đề kỹ thuật.\r\n\r\nAirbus đang đối mặt với vấn đề triệu hồi để sửa chữa động cơ trên các dòng máy bay chủ lực A320, A321 của nhiều hãng hàng không trên thế giới. Boeing lại gặp phải những vấn đề sự cố kỹ thuật trong khai thác các dòng máy bay thế hệ mới 737, dẫn đến việc chậm trễ bàn giao tàu bay cho các hãng hàng không.",
                CategoryId = 1
            },
            new TNNews
            {
                Id = 2,
                Title = "MobiFone đặt mục tiêu doanh thu gần 26.000 tỉ đồng trong năm 2024",
                Content = "Tiếp tục nỗ lực vượt qua sự khó khăn chung của thị trường kinh doanh trong những năm vừa qua, MobiFone mới đây đã công bố kế hoạch kinh doanh năm 2024. Theo đó, MobiFone đặt mục tiêu doanh thu công ty mẹ đạt gần 26.000 tỉ đồng, kế hoạch vốn đầu tư công mẹ ước tính gần 4.400 tỉ đồng.\r\n\r\nĐể đạt được mục tiêu đề ra, MobiFone dự kiến tập trung nguồn lực đầu tư vùng phủ sóng 5G và đấu giá quyền sử dụng băng tần 5G để cung cấp nhanh nhất dịch vụ đến khách hàng, phát triển hệ sinh thái giải pháp và dịch vụ số trên nền 5G hướng tới các dịch vụ tốc độ dữ liệu cao, robot…; Thực hiện triển khai lĩnh vực Không gian mới; Xây dựng IDC Hòa Lạc với quy mô 2.000 racks; Triển khai chuyển đổi số theo lộ trình chuyển đổi số MobiFone từ doanh nghiệp khai thác viễn thông truyền thống sang doanh nghiệp số; Ứng dụng các hệ thống, nền tảng công nghệ cao (AI, Big Data,…) để cá nhân hóa trải nghiệm dịch vụ khách hàng, chăm sóc khách hàng đa kênh, phát triển các kênh số,…",
                CategoryId = 1
            },
            new TNNews
            {
                Id = 3,
                Title = "Reviewer Duy Thẩm cùng CEO Tim Cook đi dạo Hồ Gươm: 'Tôi rất tự hào'",
                Content = "Sáng nay 15.4, CEO Apple Tim Cook có mặt tại Hà Nội và bức ảnh ông uống cà phê trứng cùng mẹ con ca sĩ Mỹ Linh, đi dạo Bờ Hồ cùng reviewer Ngô Đức Duy (Duy Thẩm) nhanh chóng gây sốt trên mạng xã hội.\r\nReviewer Duy Thẩm ví đây là một buổi sáng trong mơ khi được trực tiếp trò chuyện với CEO Apple.\r\n\r\n11 giờ 20, bức ảnh ông Tim Cook ngồi uống cà phê cùng ca sĩ Mỹ Linh và con gái - ca sĩ Mỹ Anh được ông chia sẻ trên mạng xã hội X. Bức ảnh nhanh chóng nhận được lượt tương tác \"khủng từ\" của dân mạng. \"Xin chào Việt Nam. Cảm ơn những nghệ sĩ âm nhạc đầy tài năng là Mỹ Linh và Mỹ Anh vì sự chào đón nồng ấm. Và tôi yêu cà phê trứng\", ông viết.\r\n\r\nTiếp đó, CEO Apple đến Hồ Gươm giao lưu cùng các content creator (nhà sáng tạo nội dung) và phóng viên một vài tờ báo. Một trong những người cùng ông Tim Cook đi dạo Hồ Gươm là reviewer Duy Thẩm - một nhà sáng tạo nội dung nổi tiếng trong lĩnh vực công nghệ trên YouTube và TikTok của Việt Nam. Bức ảnh selfie cùng Duy Thẩm cũng được CEO Apple đăng tải lên mạng xã hội với dòng trạng thái khen Hồ Hoàn Kiếm thật đẹp và chia sẻ \"Thật tuyệt vời khi dành thời gian cùng Duy và xem quá trình sáng tạo của anh ấy bằng chế độ Cinematic trên iPhone 15 Pro\".",
                CategoryId = 2
            },
            new TNNews
            {
                Id = 4,
                Title = "12 học sinh Nha Trang ngộ độc: Phát hiện khuẩn Salmonella ở khay đựng thức ăn",
                Content = "Cơ quan chức năng phát hiện khuẩn Salmonella trên dụng cụ đựng thức ăn khiến 12 học sinh Trường THPT Nguyễn Văn Trỗi, TP.Nha Trang ngộ độc phải nhập viện.\r\nNgày 15.4, Chi cục An toàn vệ sinh thực phẩm Khánh Hòa cho biết đã có báo cáo về vụ ngộ độc thực phẩm tại Trường THPT Nguyễn Văn Trỗi, TP.Nha Trang.\r\n\r\nTheo đơn vị này, trong đêm 30.3, sau khi nhận được tin báo có các trường hợp là học sinh Trường THPT Nguyễn Văn Trỗi có triệu chứng nghi ngộ độc thực phẩm nhập viện điều trị;  phòng y tế, Trung tâm Y tế TP.Nha Trang đã nhanh chóng nắm bắt thông tin, điều động nhân lực đi điều tra tại các bệnh viện có bệnh nhân nghi ngờ mắc ngộ độc thực phẩm.Qua xác minh, có 12 học sinh phải nhập viện đều có triệu chứng đau bụng, đi cầu phân lỏng, sốt, buồn nôn, nôn; được các bệnh viện chẩn đoán nhiễm trùng đường ruột, viêm dạ dày, ruột cấp, nhiễm trùng tiêu hóa, nhiễm độc thức ăn do vi khuẩn.\r\n\r\nQua khai thác thông tin, các ca bị ngộ độc thực phẩm khai báo có ăn thức ăn trước Trường THPT Nguyễn Văn Trỗi vào sáng, chiều ngày 28, 29.3.\r\n\r\nĐoàn điều tra ngộ độc thực phẩm đã phối hợp với UBND P.Xương Huân, lực lượng công an thành phố điều tra, xác minh có 3 cơ sở thức ăn đường phố phục vụ ăn uống cho học sinh tại vỉa hè số 32 Hàn Thuyên, P.Xương Huân.\r\n\r\nTại thời điểm điều tra, 3 cơ sở trên không còn mẫu thức ăn đã chế biến và mẫu nguyên liệu thực phẩm nên đoàn điều tra chỉ lấy được mẫu bàn tay người chế biến thực phẩm, mẫu bề mặt dụng cụ chứa đựng thực phẩm và mẫu nước máy dùng để rửa dụng cụ, thực phẩm.\r\n\r\nQua điều tra, các bệnh nhân đều có điểm chung là mua thức ăn của bà D.T.H.O vào sáng, chiều ngày 28, 29.3; thức ăn là mì xào gà, mì ý gà, nui gà, cơm gà, gà chiên và xốt trứng.",
                CategoryId = 3
            },
            new TNNews
            {
                Id = 5,
                Title = "Viêm họng vì dùng máy lạnh liên tục, bác sĩ chỉ ra nhiệt độ phù hợp",
                Content = "Khoảng một tháng qua, một bệnh viện tại TP.HCM ghi nhận nhiều người bị viêm họng đến khám, có trường hợp bệnh kéo dài. Nguyên nhân phần lớn gây ra các ca bệnh này là do dùng máy lạnh liên tục.\r\nViêm họng dai dẳng\r\nBé N.H.L.P (3 tuổi, ngụ quận Tân Bình, TP.HCM) cấp cứu tại Bệnh viện đa khoa Tâm Anh TP.HCM trong tình trạng sốt 39 độ C, ho, quấy khóc, bỏ ăn 3 ngày.\r\n\r\nKhai thác bệnh sử, bé P. hay viêm họng, sổ mũi. Bé thường ở trong phòng máy lạnh khi ở trường và lúc về nhà; tối ngủ phòng máy lạnh khoảng 22 độ C. Một tuần nay, bé có những triệu chứng trên nhưng uống thuốc không khỏi.\r\n\r\nSau khi khám và nội soi mũi họng, bác sĩ chẩn đoán bé P. viêm họng cấp, kê đơn thuốc, hướng dẫn mẹ bé cách chăm sóc phù hợp và theo dõi sát sao diễn biến của bệnh để tái khám theo lịch hẹn.",
                CategoryId = 3
            },
            new TNNews
            {
                Id = 6,
                Title = "Sở GD-ĐT TP.HCM làm việc với đơn vị dự kiến đầu tư vào Trường quốc tế AISVN",
                Content = "Chiều 15.4, Văn phòng UBND TP.HCM đã truyền đạt ý kiến chỉ đạo của Phó chủ tịch UBND TP.HCM Dương Anh Đức đối với Sở GD-ĐT và tổ công tác liên ngành theo hướng tăng cường theo dõi, giám sát chỉ đạo Trường quốc tế AISVN.Theo đó, Phó chủ tịch UBND TP.HCM Dương Anh Đức yêu cầu Sở GD-ĐT, tổ công tác liên ngành kiểm tra tình hình hoạt động của Công ty cổ phần Giáo dục quốc tế Mỹ AIS và Trường quốc tế AISVN.\r\n\r\nTăng cường theo dõi, giám sát, chỉ đạo Trường quốc tế AISVN đảm bảo điều kiện tổ chức học tập, nội dung chính của chương trình học, chất lượng dạy học của trường và chất lượng học tập của học sinh. Các vấn đề phát sinh, kịp thời báo cáo UBND TP.HCM xem xét, chỉ đạo.",
                CategoryId = 4
            },
            new TNNews
            {
                Id = 7,
                Title = "Lưu ý xét tuyển vào khối ngành xã hội nhân văn và sư phạm",
                Content = "Những năm gần đây, các ngành học về kinh tế, công nghệ, y tế, dịch vụ dường như thu hút thí sinh quan tâm nhiều hơn cả. Nhưng khối ngành xã hội nhân văn và sư phạm luôn quan trọng. Khi xét tuyển vào khối ngành này năm nay, thí sinh cần lưu ý gì?\r\nVào 14 giờ ngày 16.4, Báo Thanh Niên tổ chức chương trình tư vấn truyền hình trực tuyến với chủ đề \"Chọn ngành học cho tương lai: Nhu cầu nhân lực ngành xã hội nhân văn và sư phạm\". Phần 1 (14 giờ-15 giờ 30) gồm các chuyên gia:\r\n\r\nTiến sĩ Hoàng Thị Hường, Phó hiệu trưởng Trường Ngoại ngữ và xã hội nhân văn thuộc Trường ĐH Duy Tân\r\nThạc sĩ Phạm Doãn Nguyên, Phó hiệu trưởng Trường ĐH Kinh tế-Tài chính TP.HCM\r\nThạc sĩ Nguyễn Thị Xuân Dung, Giám đốc Trung tâm Truyền thông Trường ĐH Công nghệ TP.HCM\r\nThạc sĩ Trương Quang Trị, Phó phòng Công tác sinh viên Trường ĐH Nguyễn Tất ThànhPhần 2 (15 giờ 45-16 giờ 45) gồm các chuyên gia:\r\n\r\nNCS-thạc sĩ Đỗ Hồng Quân, Phó trưởng bộ môn xã hội học Trường ĐH Mở TP.HCM\r\nThạc sĩ Cao Quảng Tư, Giám đốc Tuyển sinh Trường ĐH Quốc tế Sài Gòn\r\nTiến sĩ Tô Minh Tùng, Phó trưởng khoa Ngôn ngữ và văn hóa quốc tế Trường ĐH Quốc tế Hồng Bàng\r\nTrong những năm qua, các ngành học về kinh tế, công nghệ, y tế, dịch vụ dường như thu hút thí sinh quan tâm nhiều hơn cả. Tuy nhiên, xã hội càng hiện đại và phát triển, chúng ta càng phải quan tâm đến giáo dục, đến những giá trị nền tảng để sự phát triển được cân bằng và bền vững. Đó là lý do vì sao khối ngành khoa học xã hội và sư phạm luôn quan trọng.\r\n\r\nChương trình tư vấn với những thông tin về nhu cầu nhân lực, xu hướng tuyển dụng, chỉ tiêu, chương trình học, học phí, học bổng... sẽ giúp thí sinh có định hướng và lựa chọn ngành nghề đúng đắn.\r\n\r\nBạn đọc quan tâm đến khối ngành khoa học xã hội nhân văn và sư phạm có thể đặt câu hỏi trong phần bình luận chương trình.",
                CategoryId = 4
            },
        };
                    
        public List<TNCat> GetCategories()
        {
            return AllCategories;
        }

        public List<TNNews> GetNewsList(int categoryId)
        {
            if (categoryId > 0)
            {
                var newsInCategory = AllNews.Where(news => news.CategoryId == categoryId).ToList();
                return newsInCategory.Any() ? newsInCategory : new List<TNNews>();
            }
            else
            {
                return AllNews.Take(6).ToList();
            }
        }

        public TNNews GetNewsById(int newsId)
        {
            return AllNews.FirstOrDefault(news => news.Id == newsId);
        }
    }
}
