//.NET là gì ? là một hệ sinh thái hay một nền tảng thống nhất hỗ trợ xây dựng các loại ứng dụng mà chúng ta muốn xây dựng
// API là gì ? loại mã mà chúng ta đang viết đó cũng có thể áp dụng trong rất nhiều loại ứng dụng khác vd API rất cơ bản trả về danh sách các sản phẩm của chúng tôi.
// DbContext chịu trách nhiệm mở kết nối, quản lý kết nối đến cơ sở dữ liệu
// DbContext sẽ có 1 hoặc nhiều DbSet, và những DbSet này đại diện cho những tables trong csdl
//LINQ là một công cụ giúp chúng ta truy vấn database
//Ví dụ var products = context.Products.ToList();
//Truy vấn sẽ gọi các hàm trong DbSet sau đó  truy vấn sẽ được dịch sang truy vấn SQL xuống database của chúng ta từ đó ta sẽ lấy dc danh sách sản phẩm
// sau đó những dữ liệu này sẽ được map trở lại vào entities của chúng ta, và chúng ta sẽ có một list object C# mà ta có thể sử dụng cho bất kỳ mục đích nào.
// EF Features
// Modeling ( mô hình hóa) = framework hoạt động với các đối tượng, các đối tượng lớp cũ đơn giản đôi khi được gọi là các túi có thuộc tính get / set. Và tất nhiên họ có thể có các kiểu dữ liệu khác nhau và nó sử dụng mô hình này khi truy vấn hoặc lưu
// Querying = EF cho phép ng dùng liên kết truy vấn để lấy dữ liệu từ database
// Change tracking = Nếu như ta lấy môt đối tượng từ database thì sau đó EF sẽ theo dõi(track) đối tượng đó nếu chúng ta thực hiện thay đổi object đó thì EF sẽ theo dõi nó, tiếp đến khi chúng ta save hoặc là update tất cả những thay đổi này sẽ dc cập nhật vào cơ sỡ dữ liệu
// Saving = chúng ta cũng có thể save những thứ khác vào database dựa vào bất kỳ thay đổi đã diễn ra
// Concurrency ( đồng thời) = truy cập dữ liệu đồng thời xảy ra nếu có 1 hay nhiều ng đang chỉnh sửa dữ liệu cùng 1 thời điểm, EF hỗ trợ xử lý bằng optimistic concurrency
// Transactions = Nó cũng cung cấp tính năng quản lý giao dịch, vì vậy khi chúng tôi lưu bất kỳ thay đổi nào một cách hiệu quả, chúng tôi có thể tạo danh sách các thay đổi sẽ đi vào cơ sở dữ liệu của chúng tôi và tất cả những thay đổi đó có thể được lưu trong một giao dịch duy nhất.
// Caching = Nó cũng bao gồm bộ nhớ đệm, vì vậy nếu chúng ta lấy một số sản phẩm trong cơ sở dữ liệu, sau đó chúng ta gọi lại, ví dụ sau đó nó sẽ lưu trữ nó trong bộ nhớ khi kết nối được mở, vì vậy nó không cần phải truy vấn lại nên tốc độ sẽ nhanh hơn
// Built in conventions = Nó cũng đi kèm với một số quy ước được xây dựng sẵn ví dụ chúng ta có thê cho thuộc tính Id là khóa chính 
// Configuarations = Và chúng ta cũng có thể định cấu hình các entities của mình để hoạt động với EF theo cách chúng ta muốn.
// Migrations = cho phép EF xem mã của chúng tôi và tạo một bộ lệnh để tạo cơ sở dữ liệu và các bảng dựa trên code mà chúng ta đã tạo.
//Giải thích về async và await trong API
//chúng ta sử dụng await từ khóa ở đây. Nếu cơ sở dữ liệu của chúng tôi yêu cầu một thời gian để xử lý kết quả và trả lại kết quả, thì await từ khóa sẽ tạm dừng việc GetProducts thực thi phương thức và trả về một tác vụ chưa hoàn thành. Trong thời gian đó, thread sẽ được đưa trở lại thread pool chỉ để sẵn sàng cho một yêu cầu khác. Sau khi hoạt động cơ sở dữ liệu hoàn tất, phương thức không đồng bộ sẽ tiếp tục thực thi và sẽ trả về danh sách các công ty.
//Chúng tôi không có SynchronizationContext trong các ứng dụng ASP.NET Core. ASP.NET Core tránh nắm bắt và xếp hàng đợi ngữ cảnh, tất cả những gì nó làm là lấy luồng từ nhóm luồng và gán nó cho request Vì vậy, ứng dụng sẽ ít hoạt động nền hơn. 