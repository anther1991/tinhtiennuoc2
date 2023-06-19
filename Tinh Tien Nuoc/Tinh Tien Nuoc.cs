using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;


namespace Tinh_Tien_Nuoc
{
    public partial class frmTinhTienNuoc : Form
    {
        SqlConnection sqlcon = new SqlConnection("Server=192.168.9.2;uid=NgocTam;pwd=p07FrDFrD;Database=EOSCT");
        string signature = "";
        public frmTinhTienNuoc()
        {
            InitializeComponent();
        }

        private void frmTinhTienNuoc_Load(object sender, EventArgs e)
        {
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;
        }

        private void txbDanhBo_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^\d{6}[A-Z]", RegexOptions.IgnoreCase);
            if (Convert.ToBoolean(r.Match(txbDanhBo.Text).Length))
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    string s = @"select a.TENKH, 
                                    case
				                        when a.SONHA='' then a.INHD_DIACHI
				                        else a.SONHA + ' - ' + b.TENDP
			                        end,
	                                a.MALKHDB, a.SONK, a.MAQUAN
                                from KHACHHANG a join DUONGPHO b on a.MADP=b.MADP
                                where a.MADP='" + txbDanhBo.Text.Substring(0, 3) + "' and a.MADB='" + txbDanhBo.Text.Substring(3, 4) + "'";
                    SqlDataAdapter da = new SqlDataAdapter(s, sqlcon);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "KH");
                    if (ds.Tables["KH"].Rows.Count == 1)
                    {
                        txbHoTen.Text = ds.Tables["KH"].Rows[0][0].ToString();
                        txtDiaChi.Text = ds.Tables["KH"].Rows[0][1].ToString();
                        for (int i = 0; i <= 4; i++)
                        {
                            if (cbLoaiGia.Items[i].ToString().Substring(0, 1) == ds.Tables["KH"].Rows[0][2].ToString())
                                cbLoaiGia.Text = cbLoaiGia.Items[i].ToString();
                        }
                        txtNhanKhau.Text = ds.Tables["KH"].Rows[0][3].ToString();
                        txtPhiNuocThai.Text = "10%";
                        /*if (ds.Tables["KH"].Rows[0][2].ToString() == "N")
                            txtPhiNuocThai.Text = "180";
                        else 
                            txtPhiNuocThai.Text= ds.Tables["KH"].Rows[0][4].ToString()[0]=='N'?"500":"300";*/
                    }
                    s = @"select b.M3TT, b.MALKHDB, b.SONK
                        from KHACHHANG a join TIEUTHU b on a.IDKH=b.IDKH
                        where a.MADP='" + txbDanhBo.Text.Substring(0, 3) + "' and a.MADB='" + txbDanhBo.Text.Substring(3, 4) + "'and THANG=" + nudThang.Value.ToString() + " and NAM=" + nudNam.Value.ToString();
                    da = new SqlDataAdapter(s, sqlcon);
                    da.Fill(ds, "CS");
                    if (ds.Tables["CS"].Rows.Count == 1)
                    {
                        txtTieuThu.Text = ds.Tables["CS"].Rows[0][0].ToString();
                        txtNhanKhau.Text = ds.Tables["CS"].Rows[0][2].ToString();
                        for (int i = 0; i <= 4; i++)
                        {
                            if (cbLoaiGia.Items[i].ToString().Substring(0, 1) == ds.Tables["CS"].Rows[0][1].ToString())
                                cbLoaiGia.Text = cbLoaiGia.Items[i].ToString();
                        }
                    }
                    else txtTieuThu.Text = "0";

                }
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                //Lưu chữ ký
                TextWriter txt;
                if (signature != txtNguoiLap.Text)
                {
                    txt = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Signature.txt"));
                    txt.Write(txtNguoiLap.Text);
                    txt.Close();
                }

                //Tính tiền + in báo cáo
                bool chkNhanKhau = false, chkTieuThu = false;
                int n;                
                chkNhanKhau = int.TryParse(txtNhanKhau.Text, out n);
                chkTieuThu = int.TryParse(txtTieuThu.Text, out n);
                if (txtTieuThu.Text == "")
                    MessageBox.Show("Chưa có m³ tiêu thụ!");
                else if (txtNhanKhau.Text == "")
                    MessageBox.Show("Chưa có Nhân khẩu!");
                /*else if (txtPhiNuocThai.Text == "")
                    MessageBox.Show("Chưa có Phí nước thải!");*/
                else if (cbLoaiGia.Text == "")
                    MessageBox.Show("Chưa có Loại giá!");
                else
                if (chkTieuThu && chkNhanKhau)
                    if (Convert.ToInt32(txtNhanKhau.Text) >= 0 && Convert.ToInt32(txtTieuThu.Text) >= 0)
                    {
                        try
                        {
                            double phiNuocThai = 0;
                            this.Height = 700;
                            crvPhieuTinhTien.Visible = true;
                            double tieuthu = Convert.ToDouble(txtTieuThu.Text);
                            char loaigia = Convert.ToChar(cbLoaiGia.Text.Substring(0, 1));
                            double nhankhau = Convert.ToDouble(txtNhanKhau.Text);
                            string history_Tongtien = "";
                            //int _4000, _4800, _6000, _6700, _7700, _7000, _7800, _9800; 
                            double[,] dongia = new double[9, 3];
                            dongia[1, 1] = 4000;
                            dongia[2, 1] = 5500;
                            dongia[3, 1] = 6800;
                            dongia[4, 1] = 7600;
                            dongia[5, 1] = 8700;
                            dongia[6, 1] = 8000;
                            dongia[7, 1] = 8900;
                            dongia[8, 1] = 11100;
                            //Xet gia 4000
                            if (loaigia == 'N')
                                dongia[1, 2] = tieuthu;
                            //Xet gia 4800
                            if (loaigia == 'D')
                                if (nhankhau <= 4)
                                    if (tieuthu >= 10)
                                        dongia[2, 2] = 10;
                                    else dongia[2, 2] = tieuthu;
                                else if (tieuthu <= nhankhau * 2.5)
                                    dongia[2, 2] = tieuthu;
                                else dongia[2, 2] = nhankhau * 2.5;
                            else if (loaigia == 'Q' || loaigia == 'S' || loaigia == 'K')
                                if (nhankhau == 0) dongia[2, 2] = 0;
                                else if (tieuthu > nhankhau * 2.5)
                                    dongia[2, 2] = nhankhau * 2.5;
                                else dongia[2, 2] = tieuthu;
                            //Xet gia 6000
                            if (loaigia == 'D')
                                if (nhankhau <= 4)
                                    if (tieuthu > 10 && tieuthu <= 20)
                                        dongia[3, 2] = tieuthu - 10;
                                    else if (tieuthu > 20)
                                        dongia[3, 2] = 10;
                                    else dongia[3, 2] = 0;
                                else if (tieuthu > 2.5 * nhankhau && tieuthu <= 5 * nhankhau)
                                    dongia[3, 2] = tieuthu - (2.5 * nhankhau);
                                else if (tieuthu > 5 * nhankhau)
                                    dongia[3, 2] = 2.5 * nhankhau;
                                else dongia[3, 2] = 0;
                            else dongia[3, 2] = 0;
                            //Xet gia 6700
                            if (loaigia == 'D')
                                if (nhankhau <= 4)
                                    if (tieuthu > 20 && tieuthu <= 30)
                                        dongia[4, 2] = tieuthu - 20;
                                    else if (tieuthu > 30)
                                        dongia[4, 2] = 10;
                                    else dongia[4, 2] = 0;
                                else if (tieuthu > 5 * nhankhau && tieuthu <= 7.5 * nhankhau)
                                    dongia[4, 2] = tieuthu - 5 * nhankhau;
                                else if (tieuthu > 7.5 * nhankhau)
                                    dongia[4, 2] = 2.5 * nhankhau;
                                else dongia[4, 2] = 0;
                            else dongia[4, 2] = 0;
                            //Xet gia 7700
                            if (loaigia == 'D')
                                if (nhankhau <= 4)
                                    if (tieuthu > 30)
                                        dongia[5, 2] = tieuthu - 30;
                                    else dongia[5, 2] = 0;
                                else if (tieuthu > 7.5 * nhankhau)
                                    dongia[5, 2] = tieuthu - 7.5 * nhankhau;
                                else dongia[5, 2] = 0;
                            else dongia[5, 2] = 0;
                            //Xet gia 7000
                            if (loaigia == 'Q' && tieuthu > 2.5 * nhankhau)
                                dongia[6, 2] = tieuthu - 2.5 * nhankhau;
                            else dongia[6, 2] = 0;
                            //Xet gia 7800
                            if (loaigia == 'S' && tieuthu > 2.5 * nhankhau)
                                dongia[7, 2] = tieuthu - 2.5 * nhankhau;
                            else dongia[7, 2] = 0;
                            //Xet gia 9800
                            if (loaigia == 'K' && tieuthu > 2.5 * nhankhau)
                                dongia[8, 2] = tieuthu - 2.5 * nhankhau;
                            else dongia[8, 2] = 0;

                            dsPhieuTinhTien dsphieuTinhTien = new dsPhieuTinhTien();
                            dsPhieuTinhTien.tblPhieuTinhTienRow newRow = dsphieuTinhTien.tblPhieuTinhTien.NewtblPhieuTinhTienRow();
                            newRow.hoten = txbHoTen.Text;
                            newRow.diachi = txtDiaChi.Text;
                            newRow.danhbo = txbDanhBo.Text.ToUpper();
                            newRow.ky = (nudThang.Value.ToString().Length == 1 ? '0' + nudThang.Value.ToString() : nudThang.Value.ToString()) + '/' + nudNam.Value.ToString();
                            newRow.tieuthu = Convert.ToInt32(txtTieuThu.Text);
                            newRow.doituong = cbLoaiGia.Text.Substring(0, 1);
                            newRow.nhankhau = txtNhanKhau.Text;
                            newRow.signature = txtNguoiLap.Text;
                            if (tieuthu > 0)
                            {
                                double tongtien = 0;
                                int x = 0;
                                int soluongdongia = 0;
                                int order = 0;
                                //newRow.tongtienthanhtoan = 0;
                                for (int i = 1; i <= 8; i++)
                                {
                                    if (dongia[i, 2] != 0) soluongdongia++;
                                }
                                for (int i = 1; i <= 8; i++)
                                {
                                    if (dongia[i, 2] != 0)
                                    {
                                        newRow.m3theodongia = dongia[i, 2];
                                        newRow.dongia = dongia[i, 1];
                                        newRow.tongtientheodongia = dongia[i, 2] * dongia[i, 1];
                                        newRow.tieuthu = Convert.ToDouble(txtTieuThu.Text);
                                        tongtien = newRow.tongtientheodongia;
                                        x = i;
                                        order++;
                                        break;
                                    }
                                }
                                //newRow.phinuocthai = Convert.ToInt32(txtPhiNuocThai.Text);
                                if (order == soluongdongia)
                                {
                                    newRow.signature = txtNguoiLap.Text;
                                    //newRow.phinuocthai = Convert.ToDouble(txtPhiNuocThai.Text);
                                    newRow.phinuocthai = (tongtien * 100 / 105) * 10 / 100;
                                    phiNuocThai = newRow.phinuocthai;
                                    //newRow.tongtienthanhtoan = tongtien + (Convert.ToDouble(txtPhiNuocThai.Text) * tieuthu);
                                    newRow.tongtienthanhtoan = tongtien + Math.Round(newRow.phinuocthai,0);
                                    history_Tongtien = newRow.tongtienthanhtoan.ToString();
                                }
                                dsphieuTinhTien.tblPhieuTinhTien.Rows.Add(newRow);
                                int y = x + 1;
                                for (x = y; x <= 8; x++)
                                {
                                    newRow = dsphieuTinhTien.tblPhieuTinhTien.NewtblPhieuTinhTienRow();
                                    if (dongia[x, 2] != 0)
                                    {
                                        newRow.m3theodongia = dongia[x, 2];
                                        newRow.dongia = dongia[x, 1];
                                        newRow.tongtientheodongia = dongia[x, 2] * dongia[x, 1];
                                        tongtien += newRow.tongtientheodongia;
                                        newRow.tieuthu = Convert.ToDouble(txtTieuThu.Text);
                                        order++;
                                        if (order == soluongdongia)
                                        {
                                            newRow.signature = txtNguoiLap.Text;
                                            //newRow.tongtienthanhtoan = tongtien + (Convert.ToDouble(txtPhiNuocThai.Text) * tieuthu);
                                            newRow.phinuocthai = (tongtien * 100 / 105) * 10 / 100;
                                            phiNuocThai = newRow.phinuocthai;
                                            //newRow.tongtienthanhtoan = tongtien + (Convert.ToDouble(txtPhiNuocThai.Text) * tieuthu);
                                            newRow.tongtienthanhtoan = tongtien + Math.Round(newRow.phinuocthai,0);
                                            //newRow.phinuocthai = Convert.ToDouble(txtPhiNuocThai.Text);
                                            history_Tongtien = newRow.tongtienthanhtoan.ToString();
                                        }
                                        dsphieuTinhTien.tblPhieuTinhTien.Rows.Add(newRow);
                                    }
                                }
                            }
                            if (tieuthu == 0)
                            {
                                /*newRow.m3theodongia = 0;
                                if (nhankhau == 0)
                                {
                                    if (loaigia == 'N') newRow.dongia = 4000;
                                    else if (loaigia == 'D') newRow.dongia = 4800;
                                    else if (loaigia == 'Q') newRow.dongia = 7000;
                                    else if (loaigia == 'K') newRow.dongia = 9800;
                                    else if (loaigia == 'S') newRow.dongia = 7800;
                                }
                                else
                                {
                                    if (loaigia == 'N') newRow.dongia = 4000;
                                    else newRow.dongia = 4800;
                                }
                                newRow.phinuocthai = Convert.ToDouble(txtPhiNuocThai.Text);
                                newRow.tieuthu = tieuthu;*/
                                newRow.tongtienthanhtoan = 6800;
                                history_Tongtien = "6800";
                                dsphieuTinhTien.tblPhieuTinhTien.Rows.Add(newRow);
                            }

                            DateTime dt = DateTime.Now;
                            string time = dt.ToString("dd/MM/yyy HH:mm:ss");
                            TextWriter datastream = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "History.txt"), true);
                            datastream.WriteLine(txbDanhBo.Text + "|" + txbHoTen.Text + "|" + txtDiaChi.Text + "|" + nudThang.Value.ToString() + "/" + nudNam.Value.ToString() + "|" + cbLoaiGia.Text.Substring(0, 1) + "|" + txtNhanKhau.Text + "|" + txtTieuThu.Text + "|" + Math.Round(phiNuocThai,0).ToString() + "|" + history_Tongtien + "|" + time);
                            datastream.Close();
                            crpPhieuTinhTien crpphieuTinhTien = new crpPhieuTinhTien();
                            crpphieuTinhTien.SetDatabaseLogon("NgocTam", "p07FrDFrD", "server2", "EOSCT");
                            crvPhieuTinhTien.ReportSource = crpphieuTinhTien;
                            crpphieuTinhTien.SetDataSource(dsphieuTinhTien);
                            crvPhieuTinhTien.RefreshReport();
                        }
                        catch (Exception d)
                        {
                            MessageBox.Show(d.Message);
                        }
                    }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void txtTieuThu_TextChanged(object sender, EventArgs e)
        {
            bool chkTieuThu = false;
            int n;
            chkTieuThu = int.TryParse(txtTieuThu.Text, out n);
            if (!chkTieuThu || Convert.ToInt32(txtTieuThu.Text) < 0)
                txtTieuThu.BackColor = System.Drawing.Color.Red;
            else txtTieuThu.BackColor = System.Drawing.Color.White;
        }

        private void txtNhanKhau_TextChanged(object sender, EventArgs e)
        {
            bool chkNhanKhau = false;
            int n;
            chkNhanKhau = int.TryParse(txtNhanKhau.Text, out n);
            if (!chkNhanKhau || Convert.ToInt32(txtNhanKhau.Text) < 0)
                txtNhanKhau.BackColor = System.Drawing.Color.Red;
            else txtNhanKhau.BackColor = System.Drawing.Color.White;
        }

        private void txtPhiNuocThai_TextChanged(object sender, EventArgs e)
        {
            /*bool chkPhiNuocThai = false;
            int n;
            chkPhiNuocThai = int.TryParse(txtPhiNuocThai.Text, out n);
            if (!chkPhiNuocThai || Convert.ToInt32(txtPhiNuocThai.Text) < 0)
                txtPhiNuocThai.BackColor = System.Drawing.Color.Red;
            else txtPhiNuocThai.BackColor = System.Drawing.Color.White;*/
        }

        private void frmTinhTienNuoc_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
            }
            catch (Exception a) { }
            try
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    dsPhieuTinhTien dsReloadPhieu = new dsPhieuTinhTien();
                    dsPhieuTinhTien.tblPhieuTinhTienRow newrow = dsReloadPhieu.tblPhieuTinhTien.NewtblPhieuTinhTienRow();
                    dsReloadPhieu.tblPhieuTinhTien.Rows.Add(newrow);
                    crpPhieuTinhTien crpReloadPhieu = new crpPhieuTinhTien();
                    crpReloadPhieu.SetDatabaseLogon("NgocTam", "p07FrDFrD", "server2", "EOSCT");
                    crpReloadPhieu.SetDataSource(dsReloadPhieu);
                    CrystalDecisions.Windows.Forms.CrystalReportViewer crvgiayBao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
                    crvgiayBao.ReportSource = crpReloadPhieu;
                    crvgiayBao.RefreshReport();
                }).Start();
            }
            catch (Exception g) { MessageBox.Show(g.Message); }
            try
            {
                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Signature.txt")))
                {
                    StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Signature.txt"));
                    txtNguoiLap.Text = sr.ReadLine();
                    signature = txtNguoiLap.Text;
                    sr.Close();
                }
            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmHistory a = new frmHistory();
            a.ShowDialog();
        }

    }
}
