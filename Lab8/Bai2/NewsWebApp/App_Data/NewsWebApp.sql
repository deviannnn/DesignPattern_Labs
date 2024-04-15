USE master
GO
IF exists( SELECT * FROM sysdatabases WHERE name='NewsWebApp')
	DROP DATABASE NewsWebApp

GO
CREATE DATABASE NewsWebApp

GO
USE NewsWebApp

------------------- NewsCategory -------------------
GO
CREATE TABLE NewsCategory
(
	[id] INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(50) NOT NULL
)

GO
INSERT INTO [NewsCategory] ([name]) VALUES (N'Thời sự'), (N'Kinh doanh'), (N'Khoa học'), (N'Du lịch')

------------------- NewsLocal -------------------
GO
CREATE TABLE NewsLocal
(
	[id] INT IDENTITY(1,1) PRIMARY KEY,
	[title] NVARCHAR(200) NOT NULL,
	[content] NVARCHAR(MAX) NULL,
	[category_id] INT NOT NULL
	FOREIGN KEY (category_id) REFERENCES NewsCategory(id)
)

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Đà Nẵng, Nghệ An sẽ được xem xét cơ chế đặc thù mới', N'Thường vụ Quốc hội đồng ý bổ sung vào chương trình kỳ họp Quốc hội tháng 5 hai dự thảo nghị quyết về cơ chế, chính sách đặc thù mới cho Đà Nẵng và Nghệ An.

Chiều 15/4, Ủy ban Thường vụ Quốc hội cho ý kiến về dự kiến Chương trình xây dựng luật, pháp lệnh năm 2025, điều chỉnh Chương trình năm 2024.

Sau khi xem xét đề nghị của Chính phủ, Thường vụ Quốc hội thống nhất bổ sung vào chương trình kỳ họp thứ 7 (tháng 5/2024) Nghị quyết sửa đổi Nghị quyết số 119/2020 về thí điểm tổ chức mô hình chính quyền đô thị và một số cơ chế, chính sách đặc thù phát triển Thành phố Đà Nẵng; Nghị quyết về một số cơ chế, chính sách đặc thù phát triển tỉnh Nghệ An. Hai dự thảo này sẽ được thông qua theo quy trình một kỳ họp.

Theo dự thảo, nghị quyết về cơ chế, chính sách đặc thù mới cho thành phố Đà Nẵng sẽ đề xuất 30 chính sách cụ thể, nhằm giải quyết các điểm nghẽn về thể chế, tạo thuận lợi thu hút đầu tư. Cơ quan chủ trì soạn thảo - Bộ Kế hoạch và Đầu tư đề xuất thành phố được thí điểm tổ chức đấu thầu lựa chọn nhà đầu tư; thí điểm tách dự án bồi thường, hỗ trợ, tái định cư, giải phóng mặt bằng ra khỏi dự án đầu tư công; thí điểm các dự án đầu tư theo phương thức đối tác công tư (PPP) trong lĩnh vực thể thao và văn hóa, hạ tầng thương mại.

Bộ cũng đề xuất thí điểm thành lập Khu thương mại tự do gắn với Cảng Liên Chiểu và trung tâm tài chính quốc tế tại Đà Nẵng; cho phép UBND thành phố phê duyệt điều chỉnh cục bộ quy hoạch chung. Bên cạnh đó, thành phố cũng được ưu tiên thu hút đầu tư, nhân lực giỏi vào lĩnh vực vi mạch, bán dẫn, trí tuệ nhân tạo, thông tin truyền thông, quản lý khoa học và công nghệ, đổi mới sáng tạo; có chính sách đột phá về tiền lương, thu nhập.', 1);


GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Vietnam Airlines điều chỉnh đường bay qua Trung Đông', N'Vietnam Airlines điều chỉnh các chuyến bay thường lệ giữa Hà Nội, TP HCM và châu Âu tránh xa không phận khu vực xung đột tại Trung Đông.

Ngày 15/4, đại diện Vietnam Airlines cho hay hãng đã chủ động theo dõi và chuyển hướng các chuyến bay giữa Việt Nam và châu Âu từ tuần trước để tránh xa các khu vực có thể bị ảnh hưởng bởi xung đột quân sự ở Trung Đông.

Theo đó, các chuyến bay từ Hà Nội, TP HCM đến Paris, Frankfurt, London được điều chỉnh bay qua Trung Quốc, Mông Cổ, Nga, thay vì Trung Đông và Trung Á.

Việc thay đổi này kéo dài thời gian bay giữa Việt Nam và châu Âu thêm khoảng 15 phút, đồng thời phát sinh nhiều chi phí khai thác cho hãng. Tuy nhiên, để đảm bảo an toàn cho hành khách và phi hành đoàn, Vietnam Airlines sẽ duy trì việc điều chỉnh đường bay cho đến khi tình hình căng thẳng ở Trung Đông kết thúc.

Hiện Vietnam Airlines có 25 chuyến khứ hồi mỗi tuần trên đường bay giữa Việt Nam và châu Âu.', 1);

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Giá USD ngân hàng lập đỉnh gần 25.300 đồng', N'Tỷ giá ngân hàng hôm nay tăng mạnh, vọt lên sát 25.300 đồng một USD và là mức kỷ lục từ trước đến nay.

Ngân hàng Nhà nước hôm nay công bố tỷ giá trung tâm tại 24.096 đồng, tăng 14 đồng so với cuối tuần. Với biên độ 5% so với tỷ giá trung tâm, các ngân hàng thương mại được phép mua bán USD trong vùng giá 22.891 - 25.301 đồng.

Lúc 14h40, Vietcombank niêm yết tỷ giá tại 24.900 - 25.270 đồng, tăng 90 đồng so với cuối tuần. Tỷ giá tại BIDV cũng tăng 80 đồng lên 24.840 - 25.150 đồng; Eximbank cũng nâng 80 đồng lên 24.860 - 25.250 đồng.

Tính từ đầu năm tới nay, USD trên thị trường ngân hàng đã tăng hơn 800 đồng, tương đương mức tăng khoảng 3,3%.

Còn trên thị trường tự do, giá USD mua bán sáng nay tại các điểm thu đổi cũng tăng nhẹ lên 25.450 - 25.550 đồng.

Thời gian qua, Ngân hàng Nhà nước đã phát hành 6,8 tỷ USD tín phiếu, nâng dần lãi suất liên ngân hàng 1 tháng từ 1,5% lên mức gần 4-4,5%, qua đó thu hẹp chênh lệch lãi suất USD và VND.', 2);

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Ngân hàng Nhà nước sắp đấu thầu vàng miếng', N'Ngân hàng Nhà nước sẽ đấu thầu vàng miếng trong vài ngày tới, sau hơn 10 năm dừng hoạt động này.

Ngày 15/4, Ngân hàng Nhà nước cho biết tuần này sẽ tăng cung vàng miếng ra thị trường qua đấu thầu. Cơ quan điều hành sẽ gửi thông báo trước 1 ngày cho các tổ chức tín dụng, doanh nghiệp. Họ phải đặt cọc để tham gia, muộn nhất vào 17h ngày nhận thông báo.

Sau khi Ngân hàng Nhà nước công bố giá sàn, các đơn vị sẽ có 30 phút để quyết định khối lượng và giá mua. Kết quả trúng sẽ được cơ quan điều hành công bố một tiếng sau khi kết thúc phiên.

Hiện, 26 đơn vị, gồm ngân hàng thương mại và doanh nghiệp kinh doanh vàng có giao dịch với Ngân hàng Nhà nước. Đến nay, 15 đơn vị đủ điều kiện tham gia.

Phiên đấu thầu vàng đầu tiên từng được Ngân hàng Nhà nước tổ chức vào 28/3/2013. Thời điểm đó, 1,8 triệu lượng được bán ra thị trường sau 76 phiên.', 2);

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Giải mã nơi có không khí sạch nhất hành tinh', N'Nam Đại Dương có không khí trong lành với rất ít aerosol - các hạt vật chất siêu nhỏ hình thành tự nhiên hoặc do hoạt động của con người.

Nam Đại Dương nằm cách xa nơi có nhiều hoạt động của con người, nhưng đây không phải lý do duy nhất giúp không khí tại đây trong lành nhất thế giới, Science Alert hôm 14/4 đưa tin. Trong nghiên cứu mới công bố trên tạp chí Nature, nhóm chuyên gia từ Đại học Monash và Đại học Melbourne phát hiện thông tin mới về cấu trúc mây cho thấy Nam Đại Dương và những đám mây giống tổ ong độc đáo đóng vai trò lớn như thế nào trong việc điều hòa khí hậu. Họ cũng phát hiện vai trò then chốt của mây và mưa trong việc làm sạch không khí.

Những đám mây tổ ong này có thể có cấu trúc tế bào dạng đóng kín - loại mây trắng, sáng giúp phản xạ ánh sáng Mặt Trời trở lại không gian, làm mát Trái Đất - hoặc dạng mở, cho phép nhiều ánh sáng Mặt Trời chiếu xuống Trái Đất hơn. "Những thứ phức tạp này là một nguồn gây lỗi trong việc mô hình hóa khí hậu Trái Đất vì chúng không được đưa vào một cách thích hợp. Điều quan trọng là phải đạt được sự cân bằng hợp lý giữa các tế bào mở và đóng, nếu không kết quả có thể sẽ sai", nhóm nghiên cứu viết.

Nhóm chuyên gia tin rằng họ đã tìm được sự cân bằng hợp lý và hiểu rõ hơn về vai trò của lượng mưa trong việc rửa sạch không khí. Sử dụng ảnh vệ tinh, họ so sánh đám mây tổ ong với các phép đo aerosol từ đài quan sát Kennaook/Cape Grim và lượng mưa từ những máy đo gần đó và nhận thấy, mẫu không khí sạch nhất gắn liền với sự hiện diện của mây tổ ong dạng mở.

Mây tổ ong dạng mở có độ ẩm lớn hơn, gấp khoảng 6 lần những đám mây trắng bông dạng đóng kín. Chúng khiến trời trông như ít mây khi nhìn từ vệ tinh, nhưng thực chất lại mang đến những cơn mưa rào hiệu quả nhất giúp rửa trôi aerosol. Trong khi đó, mây dạng đóng kín trông có vẻ dày dặn lại kém hiệu quả hơn.

Mây tổ ong mở xuất hiện phổ biến nhất vào mùa đông, dẫn đến không khí sạch nhất vào thời điểm đó. Ngoài Nam Đại Dương, dạng mây này cũng xuất hiện ở khu vực Bắc Đại Tây Dương và Bắc Thái Bình Dương trong mùa đông.

Dù mật độ aerosol trong không khí phía trên Nam Đại Dương chịu ảnh hưởng từ nhiều yếu tố, lượng mưa vẫn đóng vai trò chủ đạo. "Lượng mưa là điểm then chốt, đặc biệt là mưa từ những đám mây tổ ong dạng mở này. Mưa tẩy sạch các hạt aerosol trên trời giống như cách máy giặt làm sạch quần áo", nhóm nghiên cứu viết.', 3);


GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Những ngọn lửa cháy tự nhiên vĩnh cửu trên thế giới', N'Ở bên trong hang động, phía sau thác Eternal Flame cao 10,7 m ở khu bảo tồn Shale Creek (Mỹ), ngọn lửa cao khoảng 20 cm, là một trong số ngọn lửa cháy tự nhiên hàng nghìn năm.

Lửa vĩnh cửu là những ngọn lửa cháy suốt thời gian dài không tắt, có thể do nằm trên mạch khí tự nhiên hoặc ra đời do sự can thiệp của con người.

1. Thác Eternal Flame, khu bảo tồn Shale Creek, New York, Mỹ
Một ngọn lửa vĩnh cửu thuộc hàng nổi tiếng nhất thế giới nép trong hang động nhỏ phía sau thác Eternal Flame cao 10,7 m ở khu bảo tồn Shale Creek, theo Interesting Engineering. Ngọn lửa cao khoảng 20 cm đã cháy hàng nghìn năm. Các nhà nghiên cứu vẫn chưa hiểu rõ nguồn cung cấp nhiên liệu thường xuyên cho ngọn lửa vĩnh cửu này. Tuy nhiên, họ cho rằng một quá trình địa chất nào đó giải phóng khí tự nhiên đều đặn từ lớp đá phiến sét ở độ sâu 400 m. Bên trong hang động, ngọn lửa nhỏ có thể quan sát phần lớn thời gian trong năm và cháy cả vào mùa đông khi thác nước đóng băng. Thỉnh thoảng, nó có thể bị tắt và cần đốt lại.

2. Yanartas, thung lũng Olympos, Thổ Nhĩ Kỳ
Yanartas nằm trên núi Chimaera ở thung lũng Olympos tại thành phố Antalya, Thổ Nhĩ Kỳ ngày nay. Khu vực này không chỉ có một mà hàng chục ngọn lửa tự nhiên nhỏ. Những ngọn lửa vĩnh cửu ở đây nằm gần tàn tích của đền thờ cổ đại thờ Hephaestus, vị thần của thợ rèn và lửa trong thần thoại Hy Lạp. Chúng đã tồn tại qua hơn 2,5 thiên niên kỷ. Theo du khách, khu vực trông như địa ngục trên Trái Đất vào ban đêm.

3. Erta Ale, Ethiopia
Erta Ale nằm ở vùng lòng chảo Afar, Ethiopia. Với tên gọi có nghĩa "núi khói", Erta Ale là một núi lửa hình khiên cao 613 m. Đặc điểm ấn tượng nhất của nó là hồ dung nham hoạt động thường xuyên gần đó. Đây là một hiện tượng vô cùng hiếm gặp, đặc biệt khi nó tồn tại lâu như vậy. Còn có biệt danh là "cổng địa ngục", hồ dung nham của Erta Ale được phát hiện năm 1906. Chu kỳ của hồ bao gồm nguội đi, hình thành lớp màu đen và phun những ngọn lửa cao 3,96 m.

4. Yanar Dağ, Azerbaijan
Yanar Dağ ở Azerbaijan là một ngọn lửa vĩnh cửu tự nhiên ấn tượng. Nằm trên dãy núi Lesser Caucasus, Azerbaijan thường được ví như "Mảnh đất của lửa", một phần do sự tồn tại của hiện tượng tự nhiên đặc biệt này. Yanar Dag cháy nhờ khí tự nhiên rò rỉ từ lớp đá sa thạch xốp ở sườn đồi trên vịnh Absheron. Đôi khi, ngọn lửa mãnh liệt đến mức có thể bốc cao 2,74 m. Chúng được biết đến từ thời cổ đại.

5. Miệng hố gas Darvaza, Turkmenistan
Sa mạc Karakum ở Turkmenistan là một trong những ngọn lửa vĩnh cửu tự nhiên thú vị nhất thế giới. Nằm ở mỏ khí khổng lồ mà các kỹ sư xăng dầu Liên Xô (cũ) phát hiện vào thập niên 1970, đây là một trong số ít những trường hợp ra đời do bàn tay của con người. Hoạt động khoan thăm dò trong vùng dẫn tới một vụ sụp đổ dưới lòng đất, khiến giàn khoan và lều trại bị mặt đất nuốt chửng. Tuy tai nạn không gây thiệt hại về sinh mạng, lượng lớn khí methane bắt đầu phun lên bề mặt. Thay vì để methane tích tụ tới mức không an toàn, nhóm kỹ sư quyết định đốt khí gas thoát ra. Trái với dự đoán ngọn lửa sẽ tắt sau vài ngày, nó vẫn cháy suốt hơn 50 năm qua.', 3)

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Hơn 100 người chết sau 3 ngày Songkran ở Thái Lan',N'Thái Lan ghi nhận 936 vụ tai nạn đường bộ, 116 người tử vong, gồm cả du khách và dân địa phương trong ba ngày Songkran.

Số liệu này do Cục Phòng chống và giảm nhẹ thiên tai Thái Lan ghi nhận từ 11/4 đến 13/4, ba ngày cao điểm lễ Songkran. Thành phố Nakhon Si Thammarat và Songkhla có số vụ tai nạn cao nhất với 39 vụ mỗi nơi, Songkhla có số người bị thương cao nhất với 45 vụ. Bangkok đứng đầu danh sách tử vong với 8 trường hợp được ghi nhận.

Nguyên nhân gây tai nạn hàng đầu là chạy quá tốc độ chiếm 40,05%, say rượu lái xe 27,81% và tông xe 16,84%. Phương tiện gây tai nạn nhiều nhất là xe máy, chiếm 85,5%. Tai nạn xảy ra chủ yếu trên đoạn đường thẳng, chiếm 81,63%, vụ việc xảy ra trên đường cao tốc là 35,97% và đường trong phố là 30,1%.

Khoảng thời gian có tỷ lệ tai nạn cao nhất là từ 18h đến 19h. Nhóm tuổi có số người bị thương và tử vong cao nhất là 30-39 tuổi.

Tối 14/4, tại Bangkok xảy ra vụ việc du khách nước ngoài tử vong khi đang tham gia lễ hội té nước. Người này làm rơi súng nước dưới kênh và đuối nước khi nhảy xuống dòng nước vớt súng. Các nhân chứng, trong đó có nhiều khách du lịch ở hiện trường, đã cố gắng can thiệp nhưng không thể cứu kịp thời nên đã báo cơ quan chức năng yêu cầu hỗ trợ. Nguyên nhân chính xác của vụ việc đang được điều tra. Danh tính du khách nước ngoài chưa được tiết lộ.

Chính quyền Bangkok sau đó đã huy động Cục quản lý đô thị Bangkok và Cục cảnh sát Thủ đô cử thêm cảnh sát và quan chức để duy trì an ninh và đảm bảo điều kiện an toàn cho người dân và du khách tham gia các hoạt động té nước tại hai địa điểm đông khách, dễ xảy ra sự cố là đường Khao San và đường Silom.',4);

GO
INSERT INTO [NewsLocal] ([title], [content], [category_id])
VALUES
(N'Cà phê trứng - thức uống Hà Nội nhiều người nổi tiếng thế giới `ghiền`',N'CEO Apple Tim Cook, CEO Binance, Ngoại trưởng Mỹ Antony Blinken, ca sĩ John Legend đều chọn thưởng thức cà phê trứng, thức uống đặc sản trăm năm khi đến Hà Nội.

CEO Apple Tim Cook uống cà phê trứng, nhâm nhi hạt hướng dương cùng ca sĩ Mỹ Linh và con gái Mỹ Anh, sáng 15/4. Mỹ Linh tiết lộ tỷ phú Mỹ "tấm tắc khen món cà phê trứng sau vài ngụm".

Ngay sau cuộc gặp, Tim Cook có dòng tweet đầu tiên khi đến Việt Nam đăng kèm bức ảnh uống cà phê với hai ca sĩ: "Xin chào, Việt Nam! Cảm ơn hai nghệ sĩ tài năng Mỹ Linh và Mỹ Anh đã chào đón tôi nồng nhiệt. Tôi yêu cà phê trứng"

Ly cà phê trứng Tim Cook thưởng thức do Phan Lê - quản lý một nhà hàng trên phố cổ - pha chế.

Cà phê trứng là thức uống gắn liền với ẩm thực Hà Nội gần 100 năm qua, xuất hiện từ những năm 1940, là sự kết hợp giữa lòng đỏ trứng gà, sữa đặc, đường, bơ. Tất cả được đánh mịn cho bông lên rồi thưởng thức cùng cà phê nóng. Thực khách có thêm chiếc thìa nhỏ để nếm lớp bọt kem bên trên trước khi uống cà phê.

Rất nhiều nơi ở thủ đô phục vụ cà phê trứng. Lê nói quán không phải nơi bán cà phê trứng nổi tiếng nhất Hà Nội nhưng cũng có ưu điểm riêng.',4);