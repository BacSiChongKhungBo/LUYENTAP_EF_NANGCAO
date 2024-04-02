using BUS.Services;
using DAL.DomainClass;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        PhongbanService pService;
        NhanvienService nService;
        private string idWhenClick;
        public Form1()
        {
            InitializeComponent(); //tạo ra textbox, combo, dtg,... => để trên đầu
            pService = new PhongbanService();
            nService = new NhanvienService();
            SettingCombobox();
            LoadGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SettingCombobox()
        {
            //3 bước
            //B1: truyền dữ liệu vào combobox
            foreach (var pb in pService.GetPhongBans())
            {
                cmbx_TenPB.Items.Add(pb.Tenpb);//chỉ add tên PB
            }
            //B2: không cho edit combobox
            cmbx_TenPB.DropDownStyle = ComboBoxStyle.DropDownList;
            //B3: chọn sẵn 1 item mặc định (thường = 0)
            cmbx_TenPB.SelectedIndex = 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng mới
            Nhanvien nv = new Nhanvien();
            //gán các giá trị trong màn hình vào các thuộc tính đối tượng
            nv.Manv = txt_MaNV.Text;
            nv.Tennv = txt_TenNV.Text;
            nv.Mapb = pService.GetPhongBans().ElementAt(cmbx_TenPB.SelectedIndex).Mapb;
            // tìm theo vị trí mà ta đã chọn trên combobox và lấy ra thuộc tính MaPB
            //=> thêm vào database
            MessageBox.Show(nService.ThemNV(nv));
            LoadGrid();
        }

        public void LoadGrid()
        {
            dtgView.ColumnCount = 4;
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã NV";
            dtgView.Columns[2].Name = "Tên NV";
            dtgView.Columns[3].Name = "Phòng Ban";
            dtgView.Rows.Clear();
            foreach (var nv in nService.GetNVWithPBs())
            {
                dtgView.Rows.Add(nv.Stt, nv.Manv, nv.Tennv, nv.Tenpb);
            }
        }

        public void BindData()
        {
            var nv = nService.GetNVWithPBs().First(x => x.Manv == idWhenClick);
            txt_MaNV.Text = nv.Manv;
            txt_TenNV.Text = nv.Tennv;
            cmbx_TenPB.Text = nv.Tenpb;
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //4 bước: 
            //b1: xác định dòng
            int rowIndex = e.RowIndex;
            //B2: kiểm tra
            if (rowIndex < 0 || rowIndex >= nService.GetNVWithPBs().Count())
            {
                return;//ko có tương tác
            }
            //b3: lấy id trong dtgview
            idWhenClick = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            //B4: điền dữ liệu
            BindData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var nv = nService.GetNhanviens().Find(x => x.Manv == idWhenClick);
            MessageBox.Show(nService.XoaNV(nv));
            LoadGrid();
        }
    }
}
