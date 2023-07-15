namespace Moh.Cat3618 {
  //Bảng 1. Danh mục khoa, phòng, bàn khám, giường bệnh
  public class DMKhoaPhongGiuong {
    public int STT {
      get;
      set;
    }
    public int MA_LOAI_KCB {
      get;
      set;
    }
    public string MA_KHOA {
      get;
      set;
    }
    public string TEN_KHOA {
      get;
      set;
    }
    public int BAN_KHAM {
      get;
      set;
    }
    public int GIUONG_PD {
      get;
      set;
    }
    public int GIUONG_2015 {
      get;
      set;
    }
    public int GIUONG_TK {
      get;
      set;
    }
    public int GIUONG_HSTC {
      get;
      set;
    }
    public int GIUONG_HSCC {
      get;
      set;
    }
    public int LDLK {
      get;
      set;
    }
    public string LIEN_KHOA {
      get;
      set;
    }
  }
  //Bảng 2. Danh mục người hành nghề
  public class DMNhanVienYTe {
    public int STT {
      get;
      set;
    }
    public int MA_LOAI_KCB {
      get;
      set;
    }
    public string MA_KHOA {
      get;
      set;
    }
    public string TEN_KHOA {
      get;
      set;
    }
    public string MA_BHXH {
      get;
      set;
    }
    public string HO_TEN {
      get;
      set;
    }
    public int GIOI_TINH {
      get;
      set;
    }
    public string CHUCDANH_NN {
      get;
      set;
    }
    public string VI_TRI {
      get;
      set;
    }
    public string MACCHN {
      get;
      set;
    }
    public string NGAYCAP_CCHN {
      get;
      set;
    }
    public string NOICAP_CCHN {
      get;
      set;
    }
    public string PHAMVI_CM {
      get;
      set;
    }
    public string PHAMVI_CMBS {
      get;
      set;
    }
    public string DVKT_KHAC {
      get;
      set;
    }
    public string VB_PHANCONG {
      get;
      set;
    }
    public int THOIGIAN_DK {
      get;
      set;
    }
    public string THOIGIAN_NGAY {
      get;
      set;
    }
    public string THOIGIAN_TUAN {
      get;
      set;
    }
    public string CSKCB_KHAC {
      get;
      set;
    }
    public string CSKCB_CGKT {
      get;
      set;
    }
    public string QD_CGKT {
      get;
      set;
    }
  }
  //Bảng 3. Danh mục thuốc
  public class DMThuoc {
    public int STT {
      get;
      set;
    }
    public string MA_THUOC {
      get;
      set;
    }
    public string TEN_HOAT_CHAT {
      get;
      set;
    }
    public string TEN_THUOC {
      get;
      set;
    }
    public string DON_VI_TINH {
      get;
      set;
    }
    public string HAM_LUONG {
      get;
      set;
    }
    public string DUONG_DUNG {
      get;
      set;
    }
    public string MA_DUONG_DUNG {
      get;
      set;
    }
    public string DANG_BAO_CHE {
      get;
      set;
    }
    public string SO_DANG_KY {
      get;
      set;
    }
    public int SO_LUONG {
      get;
      set;
    }
    public decimal DON_GIA {
      get;
      set;
    }
    public decimal DON_GIA_BH {
      get;
      set;
    }
    public string QUY_CACH {
      get;
      set;
    }
    public string NHA_SX {
      get;
      set;
    }
    public string NUOC_SX {
      get;
      set;
    }
    public string NHA_THAU {
      get;
      set;
    }
    public string TT_THAU {
      get;
      set;
    }
    public string TU_NGAY {
      get;
      set;
    }
    public string DEN_NGAY {
      get;
      set;
    }
    public string MA_CSKCB {
      get;
      set;
    }
    public int LOAI_THUOC {
      get;
      set;
    }
    public int LOAI_THAU {
      get;
      set;
    }
    public int HT_THAU {
      get;
      set;
    }
  }

  //Bảng 4. Danh mục vật tư y tế
  public class DMVatTuYTe {
    public int STT {
      get;
      set;
    }
    public string MA_VAT_TU {
      get;
      set;
    }
    public string NHOM_VAT_TU {
      get;
      set;
    }
    public string TEN_VAT_TU {
      get;
      set;
    }
    public string MA_HIEU {
      get;
      set;
    }
    public string QUY_CACH {
      get;
      set;
    }
    public string HANG_SX {
      get;
      set;
    }
    public string NUOC_SX {
      get;
      set;
    }
    public string DON_VI_TINH {
      get;
      set;
    }
    public decimal DON_GIA {
      get;
      set;
    }
    public decimal DON_GIA_BH {
      get;
      set;
    }
    public int TYLE_TT_BH {
      get;
      set;
    }
    public int SO_LUONG {
      get;
      set;
    }
    public decimal DINH_MUC {
      get;
      set;
    }
    public string NHA_THAU {
      get;
      set;
    }
    public string TT_THAU {
      get;
      set;
    }
    public string TU_NGAY {
      get;
      set;
    }
    public string DEN_NGAY {
      get;
      set;
    }
    public string MA_CSKCB {
      get;
      set;
    }
    public int LOAI_THAU {
      get;
      set;
    }
    public int HT_THAU {
      get;
      set;
    }
  }
  //Bảng 5. Danh mục dịch vụ kỹ thuật
  public class DMDichVu {
    public int STT {
      get;
      set;
    }
    public string MA_DICH_VU {
      get;
      set;
    }
    public string TEN_DICH_VU {
      get;
      set;
    }
    public decimal DON_GIA {
      get;
      set;
    }
    public string QUY_TRINH {
      get;
      set;
    }
    public string CSKCB_CGKT {
      get;
      set;
    }
    public string CSKCB_CLS {
      get;
      set;
    }
  }
  //Bảng 6. Danh mục thiết bị y tế
  public class ThongTinThietBi {
    public int STT {
      get;
      set;
    }
    public string TEN_TB {
      get;
      set;
    }
    public string KY_HIEU {
      get;
      set;
    }
    public string CONGTY_SX {
      get;
      set;
    }
    public string NUOC_SX {
      get;
      set;
    }
    public int NAM_SX {
      get;
      set;
    }
    public int NAM_SD {
      get;
      set;
    }
    public string MA_MAY {
      get;
      set;
    }
    public string SO_LUU_HANH {
      get;
      set;
    }
    public string HD_TU {
      get;
      set;
    }
    public string HD_DEN {
      get;
      set;
    }
  }
  public static class Categories {
    //Bảng 7. Mã phạm vi hoạt động chuyên môn
    public static Dictionary < string, string > DanhSachChuyenKhoa() {
      return new Dictionary < string, string > {
        {
          "TenKhoa",
          "Hồi sức cấp cứu và Chống độc"
        },
        {
          "MaKhoa",
          "01"
        },
        {
          "TenKhoa",
          "Nội khoa"
        },
        {
          "MaKhoa",
          "02"
        },
        {
          "TenKhoa",
          "Nhi khoa"
        },
        {
          "MaKhoa",
          "03"
        },
        {
          "TenKhoa",
          "Lao"
        },
        {
          "MaKhoa",
          "04"
        },
        {
          "TenKhoa",
          "Da liễu"
        },
        {
          "MaKhoa",
          "05"
        },
        {
          "TenKhoa",
          "Tâm thần"
        },
        {
          "MaKhoa",
          "06"
        },
        {
          "TenKhoa",
          "Nội tiết"
        },
        {
          "MaKhoa",
          "07"
        },
        {
          "TenKhoa",
          "Y học cổ truyền"
        },
        {
          "MaKhoa",
          "08"
        },
        {
          "TenKhoa",
          "Gây mê hồi sức"
        },
        {
          "MaKhoa",
          "09"
        },
        {
          "TenKhoa",
          "Ngoại khoa"
        },
        {
          "MaKhoa",
          "10"
        },
        {
          "TenKhoa",
          "Bỏng"
        },
        {
          "MaKhoa",
          "11"
        },
        {
          "TenKhoa",
          "Ung bướu"
        },
        {
          "MaKhoa",
          "12"
        },
        {
          "TenKhoa",
          "Phụ sản"
        },
        {
          "MaKhoa",
          "13"
        },
        {
          "TenKhoa",
          "Mắt"
        },
        {
          "MaKhoa",
          "14"
        },
        {
          "TenKhoa",
          "Tai - Mũi - Họng"
        },
        {
          "MaKhoa",
          "15"
        },
        {
          "TenKhoa",
          "Răng - Hàm - Mặt"
        },
        {
          "MaKhoa",
          "16"
        },
        {
          "TenKhoa",
          "Phục hồi chức năng"
        },
        {
          "MaKhoa",
          "17"
        },
        {
          "TenKhoa",
          "Chẩn đoán hình ảnh"
        },
        {
          "MaKhoa",
          "18"
        },
        {
          "TenKhoa",
          "Y học hạt nhân"
        },
        {
          "MaKhoa",
          "19"
        },
        {
          "TenKhoa",
          "Nội soi chẩn đoán, can thiệp"
        },
        {
          "MaKhoa",
          "20"
        },
        {
          "TenKhoa",
          "Thăm dò chức năng"
        },
        {
          "MaKhoa",
          "21"
        },
        {
          "TenKhoa",
          "Huyết học - Truyền máu"
        },
        {
          "MaKhoa",
          "22"
        },
        {
          "TenKhoa",
          "Hóa sinh"
        },
        {
          "MaKhoa",
          "23"
        },
        {
          "TenKhoa",
          "Vi sinh, ký sinh trùng"
        },
        {
          "MaKhoa",
          "24"
        },
        {
          "TenKhoa",
          "Giải phẫu bệnh và Tế bào bệnh học"
        },
        {
          "MaKhoa",
          "25"
        },
        {
          "TenKhoa",
          "Vi phẫu"
        },
        {
          "MaKhoa",
          "26"
        },
        {
          "TenKhoa",
          "Phẫu thuật nội soi"
        },
        {
          "MaKhoa",
          "27"
        },
        {
          "TenKhoa",
          "Tạo hình - Thẩm mỹ"
        },
        {
          "MaKhoa",
          "28"
        },
        {
          "TenKhoa",
          "Đa khoa"
        },
        {
          "MaKhoa",
          "29"
        }
      };

    }

    public static Dictionary < string, string > DanhSachKhamchuyenKhoa() {
      return new Dictionary < string, string > {
        {
          "TenKhoa",
          "Nội tổng hợp"
        },
        {
          "MaKhoa",
          "02.03"
        },
        {
          "TenKhoa",
          "Nội tổng hợp"
        },
        {
          "MaKhoa",
          "02.03"
        },
        {
          "TenKhoa",
          "Nội Tim mạch"
        },
        {
          "MaKhoa",
          "02.04"
        },
        {
          "TenKhoa",
          "Nội tiêu hóa"
        },
        {
          "MaKhoa",
          "02.05"
        },
        {
          "TenKhoa",
          "Nội cơ - xương - khớp"
        },
        {
          "MaKhoa",
          "02.06"
        },
        {
          "TenKhoa",
          "Nội thận - tiết niệu"
        },
        {
          "MaKhoa",
          "02.07"
        },
        {
          "TenKhoa",
          "Nội tiết"
        },
        {
          "MaKhoa",
          "02.08"
        },
        {
          "TenKhoa",
          "Dị ứng"
        },
        {
          "MaKhoa",
          "02.09"
        },
        {
          "TenKhoa",
          "Huyết học"
        },
        {
          "MaKhoa",
          "02.10"
        },
        {
          "TenKhoa",
          "Truyền nhiễm"
        },
        {
          "MaKhoa",
          "02.11"
        },
        {
          "TenKhoa",
          "Lao"
        },
        {
          "MaKhoa",
          "02.12"
        },
        {
          "TenKhoa",
          "Da liễu"
        },
        {
          "MaKhoa",
          "02.13"
        },
        {
          "TenKhoa",
          "Thần kinh"
        },
        {
          "MaKhoa",
          "02.14"
        },
        {
          "TenKhoa",
          "Tâm thần"
        },
        {
          "MaKhoa",
          "02.15"
        },
        {
          "TenKhoa",
          "Y học cổ truyền"
        },
        {
          "MaKhoa",
          "02.16"
        },
        {
          "TenKhoa",
          "Nội Hô hấp"
        },
        {
          "MaKhoa",
          "02.50"
        },
        {
          "TenKhoa",
          "Ngoại tổng hợp"
        },
        {
          "MaKhoa",
          "10.19"
        },
        {
          "TenKhoa",
          "Ngoại thần kinh"
        },
        {
          "MaKhoa",
          "10.20"
        },
        {
          "TenKhoa",
          "Ngoại lồng ngực"
        },
        {
          "MaKhoa",
          "10.21"
        },
        {
          "TenKhoa",
          "Ngoại tiêu hóa"
        },
        {
          "MaKhoa",
          "10.22"
        },
        {
          "TenKhoa",
          "Ngoại thận - tiết niệu"
        },
        {
          "MaKhoa",
          "10.23"
        },
        {
          "TenKhoa",
          "Chấn thương chỉnh hình"
        },
        {
          "MaKhoa",
          "10.24"
        },
        {
          "TenKhoa",
          "Bỏng"
        },
        {
          "MaKhoa",
          "10.25"
        },
        {
          "TenKhoa",
          "Ung bướu"
        },
        {
          "MaKhoa",
          "10.33"
        },
        {
          "TenKhoa",
          "Tai - Mũi - Họng"
        },
        {
          "MaKhoa",
          "15.28"
        },
        {
          "TenKhoa",
          "Răng - Hàm - Mặt"
        },
        {
          "MaKhoa",
          "16.29"
        },
        {
          "TenKhoa",
          "Mắt"
        },
        {
          "MaKhoa",
          "14.30"
        },
        {
          "TenKhoa",
          "Vật lý trị liệu - Phục hồi chức năng"
        },
        {
          "MaKhoa",
          "17.31"
        },
        {
          "TenKhoa",
          "Nhi"
        },
        {
          "MaKhoa",
          "03.18"
        },
        {
          "TenKhoa",
          "Phụ sản"
        },
        {
          "MaKhoa",
          "13.27"
        }
      };

    }
  }
}
