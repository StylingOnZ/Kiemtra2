using kiemtra2.Models;
namespace kiemtra2
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        private List<Product> productList = new List<Product>();
        private void InitializeProductList()
        {
            // Khởi tạo danh sách 3 sản phẩm với tên cụ thể
            productList = new List<Product>
    {
        new Product("Bánh quy Oreo", 100000m, 20, null),
        new Product("Nước ngọt Coca-Cola", 20000m, 50, null),
        new Product("Snack khoai tây Lays", 30000m, 30, null)
    };
        }
        private void InitializeCartDataGridView()
        {
            // Thêm cột cho dataGridViewCart
            dataGridViewCart.Columns.Clear(); // Xóa cột hiện tại nếu cần
            dataGridViewCart.Columns.Add("ProductNameColumn", "Tên Sản Phẩm");
            dataGridViewCart.Columns.Add("ProductPriceColumn", "Giá");
            dataGridViewCart.Columns.Add("ProductQuantityColumn", "Số Lượng");
        }

        private void UpdateTotalQuantityAndPrice()
        {
            int totalQuantity = 0;
            decimal totalPrice = 0;

            // Tính tổng số lượng và tổng giá trị trong giỏ hàng
            foreach (var product in shoppingCart.CartItems)
            {
                totalQuantity += product.Quantity;
                totalPrice += product.Price * product.Quantity;
            }

            // Cập nhật thông tin hiển thị
            labelTotalQuantity.Text = $"Tổng Số Lượng: {totalQuantity}"; // Cập nhật tổng số lượng
            labelTotalPrice.Text = $"Tổng Giá Trị: {totalPrice:C}"; // Cập nhật tổng giá trị
        }

        private void DisplayProducts()
        {
            dataGridViewProducts.Rows.Clear(); // Xóa tất cả các hàng hiện có

            foreach (var product in productList)
            {
                int rowIndex = dataGridViewProducts.Rows.Add();
                DataGridViewRow row = dataGridViewProducts.Rows[rowIndex];

                // Giả sử bạn có 4 cột: Tên sản phẩm, Giá, Số lượng, Ảnh
                row.Cells["ProductNameColumn"].Value = product.Name; // Thay "ProductNameColumn" bằng tên cột thực tế
                row.Cells["ProductPriceColumn"].Value = product.Price; // Thay "ProductPriceColumn" bằng tên cột thực tế
                row.Cells["ProductQuantityColumn"].Value = product.Quantity; // Thay "ProductQuantityColumn" bằng tên cột thực tế

                // Nếu bạn muốn hiển thị ảnh, cần thêm xử lý để hiển thị hình ảnh trong DataGridView
                if (product.ProductImage != null)
                {
                    row.Cells["ProductImageColumn"].Value = product.ProductImage; // Thay "ProductImageColumn" bằng tên cột thực tế
                }
            }
        }
        private void InitializeDataGridView()
        {
            // Thêm cột cho dataGridViewProducts
            dataGridViewProducts.Columns.Clear(); // Xóa cột hiện tại nếu cần
            dataGridViewProducts.Columns.Add("ProductNameColumn", "Tên Sản Phẩm");
            dataGridViewProducts.Columns.Add("ProductPriceColumn", "Giá");
            dataGridViewProducts.Columns.Add("ProductQuantityColumn", "Số Lượng");
            dataGridViewProducts.Columns.Add("ProductImageColumn", "Ảnh"); // Nếu bạn muốn hiển thị ảnh
        }
        private Product GetSelectedProductFromCart()
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                string productName = selectedRow.Cells["ProductNameColumn"].Value.ToString(); // Thay "ProductNameColumn" bằng tên cột thực tế
                decimal productPrice = (decimal)selectedRow.Cells["ProductPriceColumn"].Value; // Thay "ProductPriceColumn" bằng tên cột thực tế
                int productQuantity = (int)selectedRow.Cells["ProductQuantityColumn"].Value; // Thay "ProductQuantityColumn" bằng tên cột thực tế

                // Tạo một đối tượng Product từ thông tin trong hàng đã chọn
                return new Product(productName, productPrice, productQuantity, null); // Thay null bằng ảnh nếu có
            }
            return null; // Nếu không có hàng nào được chọn
        }

        private void DisplayCartItems()
        {
            dataGridViewProducts.Rows.Clear(); // Xóa tất cả các hàng hiện có

            foreach (var product in shoppingCart.CartItems)
            {
                int rowIndex = dataGridViewProducts.Rows.Add();
                DataGridViewRow row = dataGridViewProducts.Rows[rowIndex];

                row.Cells["ProductNameColumn"].Value = product.Name; // Thay "ProductNameColumn" bằng tên cột thực tế
                row.Cells["ProductPriceColumn"].Value = product.Price; // Thay "ProductPriceColumn" bằng tên cột thực tế
                row.Cells["ProductQuantityColumn"].Value = product.Quantity; // Thay "ProductQuantityColumn" bằng tên cột thực tế
            }
        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in shoppingCart.CartItems)
            {
                totalPrice += product.Price * product.Quantity; // Cộng tổng giá trị cho mỗi sản phẩm
            }

            labelTotalPrice.Text = $"Tổng giá trị: {totalPrice:C}"; // Hiển thị tổng giá trị trong một Label, ví dụ: labelTotalPrice
        }
        private Product GetSelectedProductFromListView()
        {
            if (dataGridViewProducts.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0]; // Lấy hàng được chọn
                string productName = selectedRow.Cells["ProductNameColumn"].Value.ToString(); // Thay "ProductNameColumn" bằng tên cột thực tế
                decimal productPrice = Convert.ToDecimal(selectedRow.Cells["ProductPriceColumn"].Value); // Thay "ProductPriceColumn" bằng tên cột thực tế
                int productQuantity = Convert.ToInt32(selectedRow.Cells["ProductQuantityColumn"].Value); // Thay "ProductQuantityColumn" bằng tên cột thực tế

                // Tạo đối tượng Product từ thông tin trong hàng đã chọn
                return new Product(productName, productPrice, productQuantity, null); // Bạn có thể truyền null cho hình ảnh nếu không sử dụng
            }
            return null; // Trả về null nếu không có hàng nào được chọn
        }

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();   // Khởi tạo DataGridView cho sản phẩm
            InitializeCartDataGridView(); // Khởi tạo DataGridView cho giỏ hàng
            InitializeProductList();     // Khởi tạo danh sách sản phẩm
            DisplayProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCart.SelectedRows[0];
                string productName = selectedRow.Cells["ProductNameColumn"].Value.ToString();
                int productQuantityInCart = (int)selectedRow.Cells["ProductQuantityColumn"].Value;

                // Tìm sản phẩm tương ứng trong kho
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (row.Cells["ProductNameColumn"].Value.ToString() == productName)
                    {
                        // Tăng số lượng trong kho
                        int stockQuantity = (int)row.Cells["ProductQuantityColumn"].Value;
                        row.Cells["ProductQuantityColumn"].Value = stockQuantity + productQuantityInCart;

                        // Xóa sản phẩm khỏi giỏ hàng
                        dataGridViewCart.Rows.Remove(selectedRow);
                        UpdateTotalQuantityAndPrice(); // Cập nhật tổng số lượng và giá trị
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Lấy sản phẩm đã chọn
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                string productName = selectedRow.Cells["ProductNameColumn"].Value.ToString();
                decimal productPrice = (decimal)selectedRow.Cells["ProductPriceColumn"].Value;
                int productQuantity = (int)selectedRow.Cells["ProductQuantityColumn"].Value;

                // Kiểm tra số lượng sản phẩm
                if (productQuantity > 0)
                {
                    // Giảm số lượng trong kho
                    selectedRow.Cells["ProductQuantityColumn"].Value = productQuantity - 1;

                    // Thêm sản phẩm vào giỏ hàng
                    int rowIndex = dataGridViewCart.Rows.Add();
                    DataGridViewRow newRow = dataGridViewCart.Rows[rowIndex];
                    newRow.Cells["ProductNameColumn"].Value = productName;
                    newRow.Cells["ProductPriceColumn"].Value = productPrice;
                    newRow.Cells["ProductQuantityColumn"].Value = 1; // Mỗi lần thêm, mặc định là 1 sản phẩm

                    // Cập nhật tổng số lượng và tổng giá trị
                    shoppingCart.AddToCart(new Product(productName, productPrice, 1, null));
                    UpdateTotalQuantityAndPrice();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã hết hàng.");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo xác nhận
            var result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác Nhận Thanh Toán", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Xóa sạch giỏ hàng
                shoppingCart.CartItems.Clear();
                dataGridViewCart.Rows.Clear(); // Xóa tất cả các hàng trong DataGridView giỏ hàng

                // Đặt lại tổng giá trị đơn hàng về 0
                labelTotalPrice.Text = "Tổng giá trị: 0"; // Hoặc điều chỉnh theo cách bạn muốn hiển thị

                MessageBox.Show("Cảm ơn bạn đã thanh toán!", "Thanh Toán Thành Công");
            }
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
