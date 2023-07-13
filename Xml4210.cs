namespace Moh.Xml4210
{
    //TỔNG HỢP KHÁM BỆNH, CHỮA BỆNH BHYT
    public class XML1
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_BN { get; set; }
        public string HO_TEN { get; set; }
        public string NGAY_SINH { get; set; }
        public int GIOI_TINH { get; set; }
        public string DIA_CHI { get; set; }
        public string MA_THE { get; set; }
        public string MA_DKBD { get; set; }
        public string GT_THE_TU { get; set; }
        public string GT_THE_DEN { get; set; }
        public string MIEN_CUNG_CT { get; set; }
        public string TEN_BENH { get; set; }
        public string MA_BENH { get; set; }
        public string MA_BENHKHAC { get; set; }
        public int MA_LYDO_VVIEN { get; set; }
        public string MA_NOI_CHUYEN { get; set; }
        public int MA_TAI_NAN { get; set; }
        public string NGAY_VAO { get; set; }
        public string NGAY_RA { get; set; }
        public int SO_NGAY_DTRI { get; set; }
        public int KET_QUA_DTRI { get; set; }
        public int TINH_TRANG_RV { get; set; }
        public string NGAY_TTOAN { get; set; }
        public long T_THUOC { get; set; }
        public long T_VTYT { get; set; }
        public long T_TONGCHI { get; set; }
        public long T_BNTT { get; set; }
        public long T_BNCCT { get; set; }
        public long T_BHTT { get; set; }
        public long T_NGUONKHAC { get; set; }
        public long T_NGOAIDS { get; set; }
        public int NAM_QT { get; set; }
        public int THANG_QT { get; set; }
        public int MA_LOAI_KCB { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_CSKCB { get; set; }
        public string MA_KHUVUC { get; set; }
        public string MA_PTTT_QT { get; set; }
        public float CAN_NANG { get; set; }
    }
    //CHI TIẾT THUỐC THANH TOÁN BHYT
    public class XML2
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_THUOC { get; set; }
        public int MA_NHOM { get; set; }
        public string TEN_THUOC { get; set; }
        public string DON_VI_TINH { get; set; }
        public string HAM_LUONG { get; set; }
        public string DUONG_DUNG { get; set; }
        public string LIEU_DUNG { get; set; }
        public string SO_DANG_KY { get; set; }
        public string TT_THAU { get; set; }
        public int PHAM_VI { get; set; }
        public int TYLE_TT { get; set; }
        public int SO_LUONG { get; set; }
        public long DON_GIA { get; set; }
        public long THANH_TIEN { get; set; }
        public int MUC_HUONG { get; set; }
        public long T_NGUON_KHAC { get; set; }
        public long T_BNTT { get; set; }
        public long T_BHTT { get; set; }
        public long T_BNCCT { get; set; }
        public long T_NGOAIDS { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_BAC_SI { get; set; }
        public string MA_BENH { get; set; }
        public string NGAY_YL { get; set; }
        public int MA_PTTT { get; set; }
    }
    //CHI TIẾT DỊCH VỤ KỸ THUẬT VÀ VẬT TƯ Y TẾ THANH TOÁN BHYT
    public class XML3
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_DICH_VU { get; set; }
        public string MA_VAT_TU { get; set; }
        public int MA_NHOM { get; set; }
        public string GOI_VTYT { get; set; }
        public string TEN_VAT_TU { get; set; }
        public string TEN_DICH_VU { get; set; }
        public string DON_VI_TINH { get; set; }
        public int PHAM_VI { get; set; }
        public int SO_LUONG { get; set; }
        public long DON_GIA { get; set; }
        public string TT_THAU { get; set; }
        public int TYLE_TT { get; set; }
        public long THANH_TIEN { get; set; }
        public long T_TRANTT { get; set; }
        public int MUC_HUONG { get; set; }
        public long T_NGUONKHAC { get; set; }
        public long T_BNTT { get; set; }
        public long T_BHTT { get; set; }
        public long T_BNCCT { get; set; }
        public long T_NGOAIDS { get; set; }
        public string MA_KHOA { get; set; }
        public string MA_GIUONG { get; set; }
        public string MA_BAC_SI { get; set; }
        public string MA_BENH { get; set; }
        public string NGAY_YL { get; set; }
        public string NGAY_KQ { get; set; }
        public int MA_PTTT { get; set; }
    }
    //CHỈ SỐ KẾT QUẢ CẬN LÂM SÀNG
    public class XML4
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string MA_DICH_VU { get; set; }
        public string MA_CHI_SO { get; set; }
        public string TEN_CHI_SO { get; set; }
        public string GIA_TRI { get; set; }
        public string MA_MAY { get; set; }
        public string MO_TA { get; set; }
        public string KET_LUAN { get; set; }
        public string NGAY_KQ { get; set; }
    }
    //THEO DÕI DIỄN BIẾN LÂM SÀNG
    public class XML5
    {
        public string MA_LK { get; set; }
        public int STT { get; set; }
        public string DIEN_BIEN { get; set; }
        public string HOI_CHAN { get; set; }
        public string PHAU_THUAT { get; set; }
        public string NGAY_YL { get; set; }
    }

}
