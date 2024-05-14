using System.Collections.Generic;
using App.Models;

namespace App.Services
{
    public class PlanetService : List<PlanetModel>
    {
        public PlanetService()
        {
            Add(new PlanetModel(){
                Id = 1,
                Name = "Mercury",
                VnName = "Sao Thủy",
                Content = "Sao Thủy (cách Mặt Trời khoảng 0,4 AU) là hành tinh gần Mặt Trời nhất và là hành tinh nhỏ nhất trong Hệ Mặt Trời (0,055 lần khối lượng Trái Đất). Sao Thủy không có vệ tinh tự nhiên, và nó chỉ có các đặc trưng địa chất bên cạnh các hố va chạm đó là các sườn và vách núi, có lẽ được hình thành trong giai đoạn co lại đầu tiên trong lịch sử của nó.[32] Sao Thủy hầu như không có khí quyển do các nguyên tử trong bầu khí quyển của nó đã bị gió Mặt Trời thổi bay ra ngoài không gian.[33] Hành tinh này có lõi sắt tương đối lớn và lớp phủ khá mỏng mà vẫn chưa được các nhà thiên văn giải thích được một cách đầy đủ. Có giả thuyết cho rằng lớp phủ bên ngoài đã bị tước đi sau 1 vụ va chạm khổng lồ, và quá trình bồi tụ vật chất của Sao Thủy bị ngăn chặn bởi năng lượng của Mặt Trời trẻ.",
            });

            Add(new PlanetModel(){
                Id = 2,
                Name = "Venus",
                VnName = "Sao Kim",
                Content = "Sao Kim (cách Mặt Trời khoảng 0,7 AU) có kích cỡ khá gần với kích thước Trái Đất (với khối lượng bằng 0,815 lần khối lượng Trái Đất) và đặc điểm cấu tạo giống Trái Đất, nó có 1 lớp phủ silicat dày bao quanh 1 lõi sắt. Sao Kim có 1 bầu khí quyển dày và có những chứng cứ cho thấy hành tinh này còn sự hoạt động của địa chất bên trong nó. Tuy nhiên, Sao Kim khô hơn Trái Đất rất nhiều và mật độ bầu khí quyển của nó gấp 90 lần mật độ bầu khí quyển của Trái Đất. Sao Kim không có vệ tinh tự nhiên. Nó là hành tinh nóng nhất trong Hệ Mặt Trời với nhiệt độ của bầu khí quyển trên 400 °C, nguyên nhân chủ yếu là do hiệu ứng nhà kính của bầu khí quyển.[36] Không có dấu hiệu cụ thể về hoạt động địa chất gần đây được phát hiện trên Sao Kim (1 lý do là nó có bầu khí quyển quá dày), mặt khác hành tinh này không có từ trường để ngăn chặn sự suy giảm đáng kể của bầu khí quyển, và điều này gợi ra rằng bầu khí quyển của nó thường xuyên được bổ sung bởi các vụ phun trào núi lửa.",
            });

            Add(new PlanetModel(){
                Id = 3,
                Name = "Earth",
                VnName = "Trái Đất",
                Content = "Trái Đất (cách Mặt Trời 1 AU) là hành tinh lớn nhất và có mật độ lớn nhất trong số các hành tinh vòng trong, cũng là hành tinh duy nhất mà chúng ta biết còn có các hoạt động địa chất gần đây, và là hành tinh duy nhất trong vũ trụ được biết đến là nơi có sự sống tồn tại.[38] Trái Đất cũng là hành tinh đá duy nhất có thủy quyển lỏng, và cũng là hành tinh duy nhất nơi quá trình kiến tạo mảng đã được quan sát. Bầu khí quyển của Trái Đất cũng khác căn bản so với các hành tinh khác với thành phần phân tử oxy tự do thiết yếu cho sự sống chiếm tới 21% trong bầu khí quyển.[39] Trái Đất có 1 vệ tinh tự nhiên là Mặt Trăng, nó là vệ tinh tự nhiên lớn nhất trong số các vệ tinh của các hành tinh đá trong Hệ Mặt Trời.",
            });

            Add(new PlanetModel(){
                Id = 4,
                Name = "Mars",
                VnName = "Sao Hỏa",
                Content = "Sao Hỏa (cách Mặt Trời khoảng 1,5 AU) có kích thước nhỏ hơn Trái Đất và Sao Kim (khối lượng bằng 0,107 lần khối lượng Trái Đất). Nó có 1 bầu khí quyển chứa chủ yếu là carbon dioxide (CO2) với áp suất khí quyển tại bề mặt bằng 6,1 millibar (gần bằng 0,6% áp suất khí quyển tại bề mặt của Trái Đất).[40] Trên bề mặt hành tinh đỏ có những ngọn núi khổng lồ như Olympus Mons (cao nhất trong Hệ Mặt Trời) và những rặng thung lũng như Valles Marineris, với những hoạt động địa chất có thể đã tồn tại cho đến cách đây 2 triệu năm về trước.[41] Bề mặt của nó có màu đỏ do trong đất bề mặt có nhiều sắt oxide (gỉ).[42] Sao Hỏa có 2 Mặt Trăng rất nhỏ (Deimos và Phobos) được cho là các tiểu hành tinh bị Sao Hỏa bắt giữ.[43] Sao Hỏa là hành tinh có cấu tạo gần giống Trái Đất nhất.",
            });

            Add(new PlanetModel(){
                Id = 5,
                Name = "Jupiter",
                VnName = "Sao Mộc",
                Content = "Sao Mộc (khoảng cách đến Mặt Trời 5,2 AU), với khối lượng bằng 318 lần khối lượng Trái Đất và bằng 2,5 lần tổng khối lượng của 7 hành tinh còn lại trong Thái Dương Hệ. Mộc Tinh có thành phần chủ yếu hiđrô và heli. Nhiệt lượng khổng lồ từ bên trong Sao Mộc tạo ra một số đặc trưng bán vĩnh cửu trong bầu khí quyển của nó, như các dải mây và Vết đỏ lớn. Sao Mộc có 63 vệ tinh đã biết. 4 vệ tinh lớn nhất, Ganymede, Callisto, Io, và Europa (các vệ tinh Galileo) có các đặc trưng tương tự như các hành tinh đá, như núi lửa và nhiệt lượng từ bên trong.[56] Ganymede, vệ tinh tự nhiên lớn nhất trong Hệ Mặt Trời, có kích thước lớn hơn Sao Thủy.",
            });

            Add(new PlanetModel(){
                Id = 6,
                Name = "Uranus",
                VnName = "Sao Thiên Vương",
                Content = "Sao Thiên Vương (khoảng cách đến Mặt Trời 19,6 AU), khối lượng bằng 14 lần khối lượng Trái Đất, là hành tinh vòng ngoài nhẹ nhất. Trục tự quay của nó có đặc trưng lạ thường duy nhất so với các hành tinh khác, độ nghiêng trục quay >900 so với mặt phẳng hoàng đạo. Thiên Vương Tinh có lõi lạnh hơn nhiều so với các hành tinh khí khổng lồ khác và nhiệt lượng bức xạ vào không gian cũng nhỏ.[58] Sao Thiên Vương có 27 vệ tinh tự nhiên đã biết, lớn nhất theo thứ tự từ lớn đến nhỏ là Titania, Oberon, Umbriel, Ariel và Miranda.",
            });

            Add(new PlanetModel(){
                Id = 7,
                Name = "Neptune",
                VnName = "Sao Hải Vương",
                Content = "Sao Hải Vương (khoảng cách đến Mặt Trời 30 AU), mặc dù kích cỡ hơi nhỏ hơn Sao Thiên Vương nhưng khối lượng của nó lại lớn hơn (bằng 17 lần khối lượng của Trái Đất) và do vậy khối lượng riêng lớn hơn. Nó cũng bức xạ nhiều nhiệt lượng hơn nhưng không lớn bằng của Sao Mộc hay Sao Thổ.[59] Hải Vương Tinh có 13 vệ tinh tự nhiên đã biết. Triton là vệ tinh lớn nhất vầ còn sự hoạt động địa chất với các mạch phun nitơ lỏng.[60] Triton cũng là vệ tinh tự nhiên duy nhất có quỹ đạo nghịch hành. Trên cùng quỹ đạo của Sao Hải Vương cũng có một số hành tinh vi hình (minor planet), gọi là các thiên thể Troia của Sao Hải Vương, chúng cộng hưởng quỹ đạo 1:1 với Sao Hải Vương.",
            });

            Add(new PlanetModel(){
                Id = 8,
                Name = "Saturn",
                VnName = "Sao Thổ",
                Content = "là hành tinh thứ sáu tính theo khoảng cách trung bình từ Mặt Trời và là hành tinh lớn thứ hai về đường kính cũng như khối lượng, sau Sao Mộc trong hệ Mặt Trời. Tên tiếng Anh của hành tinh mang tên thần Saturn trong thần thoại La Mã, ký hiệu thiên văn của hành tinh là (♄) thể hiện cái liềm của thần. Sao Thổ là hành tinh khí khổng lồ với bán kính trung bình bằng 9 lần của Trái Đất.[14][15] Tuy khối lượng của hành tinh cao gấp 95 lần khối lượng của Trái Đất nhưng với thể tích lớn hơn 763 lần, khối lượng riêng trung bình của Sao Thổ chỉ bằng một phần tám so với của Trái Đất.",
            });            
        }
    }

}