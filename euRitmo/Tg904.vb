Imports System.Formats.Asn1.AsnWriter
Imports System.Net
Imports System.Runtime.Intrinsics.X86
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Tg904
    Friend Tes As Tes
    Friend forn As Forn
    Friend rub As Rub
    Friend pdv As Pdv
    Friend tsp As Tsp
    Friend mit As Mit
    Friend DetList As New List(Of BloccoDet)
    Friend endtr As EndTr
    Friend ppi As PPI_PPT
    Friend xna As Xna_Xft
    Friend ppt As PPI_PPT
    Friend xft As Xna_Xft
    Public Overrides Function Tostring() As String
        Dim str = ""
        If Not IsNothing(Tes) Then

            str = Tes.ToString()
        End If
        Return str
    End Function
End Class
Public Class Det
    Friend SCHEMA As String
    Friend NART_ORD_D As String
    Friend NART_ORD_OM_D As String
    Friend NART_CON_D As String
    Friend NART_CON_OM_D As String
    Friend CART_OR_D As String
    Friend CART_ORD_OM_D As String
    Friend CART_CON_D As String
    Friend CART_CON_OM_D As String
    Friend PLT_ORD_D As String
    Friend PLT_CON_D As String
    Friend FORM_PLT_FORN As String
    Friend CART_STRATO_FOR As String
    Friend NUM_STRATO_FOR As String
    Friend QTA_FORN_FOR As String
    Friend QTA_TERMO_FOR As String
    Friend NOTE_ORD_D As String
    Friend PNT_CAR As String
    Friend STATO_RIG As String
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        SCHEMA = line.Substring(3, 4).Trim()
        NART_ORD_D = line.Substring(7, 10).Trim()
        NART_ORD_OM_D = line.Substring(17, 10).Trim()
        NART_CON_D = line.Substring(27, 10).Trim()
        NART_ORD_OM_D = line.Substring(37, 10).Trim()
        CART_OR_D = line.Substring(47, 10).Trim()
        CART_ORD_OM_D = line.Substring(57, 10).Trim()
        PLT_ORD_D = line.Substring(67, 10).Trim()
        PLT_CON_D = line.Substring(77, 10).Trim()
        FORM_PLT_FORN = line.Substring(87, 8).Trim()
        CART_STRATO_FOR = line.Substring(95, 8).Trim()
        QTA_FORN_FOR = line.Substring(103, 20).Trim()
        NOTE_ORD_D = line.Substring(123, 80).Trim()
        PNT_CAR = line.Substring(203, 8).Trim()
        STATO_RIG = line.Substring(211, 1).Trim()
    End Sub
End Class

Public Class BloccoDet
    Friend det As New Dett()
    Friend pro As New Pro()
    Friend coList As New List(Of CO)
End Class
Public Class Tes
    Friend TRK As String
    Friend OP As String
    Friend DTOPE As String
    Friend TMOPE As String
    Friend DTPC As String
    Friend CMPT As String
    Friend STATO_ORD As String
    Friend COD_BUYER As String
    Friend DES_BUYER As String
    Friend NART_ORD_T As String
    Friend NART_CON_T As String
    Friend CART_ORD_OMT_T As String
    Friend CART_CON_T As String
    Friend CART_CON_OM_T As String
    Friend PLT_ORD_T As String
    Friend PLT_CON_T As String
    Friend VAL_ORD_T As String
    Friend NOTE_ORD_T As String
    Friend SC_ORD_T As String
    Friend DTCON As String
    Friend DTDOC As String
    Friend ORD As String
    Friend DTORD As String
    Friend MAG As String
    Friend CODFOR As String
    Friend CART_ORD_T As String
    Friend CART_ORD_OM_T As String
    Friend NDOC As String
    Friend CAU As String
    Friend CAU_DES As String
    Friend TRANS As String
    Friend DESOP As String
    Friend EDI_MITT1 As String
    Friend EDI_MITT2 As String
    Friend EDI_DEST1 As String
    Friend EDI_DEST2 As String
    Friend FHH As String
    Friend FHH_DES As String
    Friend FHH_TMI_HH As String
    Friend FHH_TMI_MM As String
    Friend FHH_TMF_HH As String
    Friend FHH_TMF_MM As String
    Friend MTO_IND As String
    Friend FAX_NUM As String
    Friend NOME_BUYER As String
    Friend CGNM_BUYER As String
    Friend CELL_BUYER As String
    Friend EMAIL_BUYER As String
    Friend ID_CNT As String
    Friend CPAG As String
    Friend CPAG_DES As String
    Friend NAS_CODFORN As String
    Friend NAS_QCODFORN As String
    Friend TEEDIUM As String
    Friend TEMEA As String
    Friend TEOM As String
    Public Sub New()
    End Sub

    Public Sub New(ByVal stringTes As String)
        TRK = stringTes.Substring(0, 3).Trim()
        OP = stringTes.Substring(3, 1).Trim()
        TMOPE = stringTes.Substring(12, 8).Trim()
        ORD = stringTes.Substring(20, 10).Trim()
        DTORD = stringTes.Substring(30, 8).Trim()
        MAG = stringTes.Substring(38, 2).Trim()
        CODFOR = stringTes.Substring(40, 6).Trim()
        DTPC = stringTes.Substring(46, 8).Trim()
        CMPT = stringTes.Substring(54, 4).Trim()
        STATO_ORD = stringTes.Substring(58, 1).Trim()
        COD_BUYER = stringTes.Substring(59, 4).Trim()
        DES_BUYER = stringTes.Substring(63, 8).Trim()
        NART_ORD_T = stringTes.Substring(71, 8).Trim() 'Togliamo il segno?'
        NART_CON_T = stringTes.Substring(77, 6).Trim()
        CART_ORD_T = stringTes.Substring(83, 10).Trim()
        CART_ORD_OM_T = stringTes.Substring(93, 10).Trim()
        CART_CON_T = stringTes.Substring(103, 10).Trim()
        CART_CON_OM_T = stringTes.Substring(113, 10).Trim()
        PLT_ORD_T = stringTes.Substring(123, 8).Trim()
        PLT_CON_T = stringTes.Substring(131, 8).Trim()
        VAL_ORD_T = stringTes.Substring(139, 14).Trim()
        NOTE_ORD_T = stringTes.Substring(153, 80).Trim()
        SC_ORD_T = stringTes.Substring(233, 6).Trim()
        DTCON = stringTes.Substring(239, 8).Trim()
        DTDOC = stringTes.Substring(247, 8).Trim()
        NDOC = stringTes.Substring(255, 11).Trim()
        CAU = stringTes.Substring(266, 4).Trim()
        CAU_DES = stringTes.Substring(270, 30).Trim()
        TRANS = stringTes.Substring(300, 10).Trim()
        DESOP = stringTes.Substring(310, 30).Trim()
        EDI_MITT1 = stringTes.Substring(340, 35).Trim()
        EDI_MITT2 = stringTes.Substring(375, 4).Trim()
        EDI_DEST1 = stringTes.Substring(379, 35).Trim()
        EDI_DEST2 = stringTes.Substring(414, 4).Trim()
        FHH = stringTes.Substring(418, 4).Trim()
        FHH_DES = stringTes.Substring(422, 30).Trim()
        FHH_TMI_HH = stringTes.Substring(452, 2).Trim()
        FHH_TMI_MM = stringTes.Substring(454, 2).Trim()
        FHH_TMF_HH = stringTes.Substring(456, 2).Trim()
        FHH_TMF_MM = stringTes.Substring(458, 2).Trim()
        MTO_IND = stringTes.Substring(460, 50).Trim()
        FAX_NUM = stringTes.Substring(510, 20).Trim()
        NOME_BUYER = stringTes.Substring(530, 30).Trim()
        CGNM_BUYER = stringTes.Substring(560, 30).Trim()
        CELL_BUYER = stringTes.Substring(590, 20).Trim()
        EMAIL_BUYER = stringTes.Substring(610, 60).Trim()
        ID_CNT = stringTes.Substring(670, 20).Trim()
        CPAG = stringTes.Substring(690, 4).Trim()
        CPAG_DES = stringTes.Substring(694, 30).Trim()
        NAS_CODFORN = stringTes.Substring(724, 35).Trim()
        NAS_QCODFORN = stringTes.Substring(759, 4).Trim()
        TEEDIUM = stringTes.Substring(763, 1).Trim()
        TEMEA = stringTes.Substring(764, 1).Trim()
        TEOM = stringTes.Substring(765, 1).Trim()
    End Sub
End Class
Public Class Forn
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        '' MessageBox.Show("FORN " & line).Trim()
        TRK = line.Substring(0, 3).Trim()
        RAGSOC_For = line.Substring(3, 50).Trim()
        RAGSOC_E_FOR = line.Substring(53, 40).Trim()
        BANCA_FOR = line.Substring(93, 35).Trim()
        RAPP_TEL = line.Substring(128, 15).Trim()
        TELEX_FOR = line.Substring(143, 10).Trim()
        FAX_FOR = line.Substring(153, 10).Trim()
        RAPP = line.Substring(163, 35).Trim()
        RAPP_TEL = line.Substring(198, 15).Trim()
        CAPO_AREA = line.Substring(213, 35).Trim()
        CAPO_AREA_TEL = line.Substring(248, 15).Trim()
        DIR_COMM = line.Substring(263, 35).Trim()
        DIR_COMM_TEL = line.Substring(298, 15).Trim()
        COD_PAG1 = line.Substring(313, 3).Trim()
        COD_PAG2 = line.Substring(316, 3).Trim()
        COD_PAG3 = line.Substring(319, 3).Trim()
        NOTE1_FOR = line.Substring(322, 72).Trim()
        NOTE2_For = line.Substring(394, 72).Trim()
        IND_FOR = line.Substring(466, 50).Trim()
        CAP_FOR = line.Substring(516, 5).Trim()
        LOC_FOR = line.Substring(521, 50).Trim()
        PROV_FOR = line.Substring(571, 3).Trim()
        CODFISC_For = line.Substring(574, 16).Trim()
        PARTIVA_FOR = line.Substring(590, 11).Trim()
        ORA_PREF = line.Substring(601, 4).Trim()
        EMAIL1 = line.Substring(605, 50).Trim()
        EMAIL2 = line.Substring(655, 50).Trim()
        EMAIL3 = line.Substring(705, 50).Trim()
        WEB = line.Substring(755, 50).Trim()
        TELEX_FOR1 = line.Substring(805, 15).Trim()
        FAX_FOR1 = line.Substring(820, 15).Trim()
        COD_PAG = line.Substring(835, 3).Trim()
        COD_PAG_DES = line.Substring(838, 30).Trim()
        FG050_FLAG1 = line.Substring(868, 1).Trim()
        FG050_FLAG2 = line.Substring(869, 1).Trim()
        FG050_FLAG3 = line.Substring(870, 1).Trim()
        FG050_FLAG4 = line.Substring(871, 1).Trim()
        FG050_FLAG5 = line.Substring(872, 1).Trim()
        CODFORR = line.Substring(873, 6).Trim()
    End Sub
    Friend TRK As String
    Friend RAGSOC_For As String
    Friend RAPP_TEL As String
    Friend RAGSOC_E_FOR As String
    Friend BANCA_FOR As String
    Friend TELEFONO_FOR As String
    Friend TELEX_FOR As String
    Friend FAX_FOR As String
    Friend RAPP As String
    Friend CAPO_AREA As String
    Friend CAPO_AREA_TEL As String
    Friend DIR_COMM As String
    Friend DIR_COMM_TEL As String
    Friend COD_PAG1 As String
    Friend COD_PAG2 As String
    Friend COD_PAG3 As String
    Friend NOTE1_FOR As String
    Friend NOTE2_For As String
    Friend IND_FOR As String
    Friend CAP_FOR As String
    Friend LOC_FOR As String
    Friend PROV_FOR As String
    Friend CODFISC_For As String
    Friend PARTIVA_FOR As String
    Friend ORA_PREF As String
    Friend EMAIL1 As String
    Friend EMAIL2 As String
    Friend EMAIL3 As String
    Friend WEB As String
    Friend TELEX_FOR1 As String
    Friend FAX_FOR1 As String
    Friend COD_PAG As String
    Friend COD_PAG_DES As String
    Friend FG050_FLAG1 As String
    Friend FG050_FLAG2 As String
    Friend FG050_FLAG3 As String
    Friend FG050_FLAG4 As String
    Friend FG050_FLAG5 As String
    Friend CODFORR As String
End Class
Public Class Rub
    Friend TRK As String
    Friend RUB_SERVIZIO As String
    Friend RUB_IND As String
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        RUB_SERVIZIO = line.Substring(3, 8).Trim()
        RUB_IND = line.Substring(12, 200).Trim()
    End Sub
End Class
Public Class Pdv
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        RAGSOC_PDV = line.Substring(3, 50).Trim()
        RAGSOC_E_PDV = line.Substring(53, 40).Trim()
        TELEFONO_PDV = line.Substring(93, 15).Trim()
        TELEX_PDV = line.Substring(108, 10).Trim()
        FAX_PDV = line.Substring(118, 10).Trim()
        IND_PDV = line.Substring(128, 50).Trim()
        CAP_PDV = line.Substring(178, 5).Trim()
        LOC_PDV = line.Substring(183, 50).Trim()
        PROV_PDV = line.Substring(233, 3).Trim()
        IND_BC_PDV = line.Substring(236, 50).Trim()
        CAP_BC_PDV = line.Substring(286, 5).Trim()
        LOC_BC_PDV = line.Substring(291, 50).Trim()
        PROV_BC_PDV = line.Substring(341, 3).Trim()
        CODFISC_PDV = line.Substring(344, 16).Trim()
        PARTIVA_PDV = line.Substring(360, 11).Trim()
        EMAIL1_PDV = line.Substring(371, 50).Trim()
        EMAIL2_PDV = line.Substring(421, 50).Trim()
        EMAIL3_PDV = line.Substring(471, 50).Trim()
        CODSEDEAMM_PDV = line.Substring(521, 6).Trim()
        CODSEDELEG_PDV = line.Substring(527, 6).Trim()
        COD_PDV = line.Substring(533, 6).Trim()

    End Sub
    Friend TRK As String
    Friend RAGSOC_PDV As String
    Friend RAGSOC_E_PDV As String
    Friend TELEFONO_PDV As String
    Friend TELEX_PDV As String
    Friend FAX_PDV As String
    Friend IND_PDV As String
    Friend CAP_PDV As String
    Friend LOC_PDV As String
    Friend PROV_PDV As String
    Friend IND_BC_PDV As String
    Friend CAP_BC_PDV As String
    Friend LOC_BC_PDV As String
    Friend PROV_BC_PDV As String
    Friend CODFISC_PDV As String
    Friend PARTIVA_PDV As String
    Friend EMAIL1_PDV As String
    Friend EMAIL2_PDV As String
    Friend EMAIL3_PDV As String
    Friend CODSEDEAMM_PDV As String
    Friend CODSEDELEG_PDV As String
    Friend COD_PDV As String
End Class

Public Class Tsp
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        CODTRASP = line.Substring(3, 6).Trim()
        CODTRASP_TE1 = line.Substring(9, 1).Trim()
        CODTRASP_TE2 = line.Substring(10, 1).Trim()
        CODTRASP_TE3 = line.Substring(11, 1).Trim()
        CODTRASP_TE4 = line.Substring(12, 1).Trim()
        CODTRASP_TE5 = line.Substring(13, 1).Trim()
        CODTRASP_RS = line.Substring(14, 50).Trim()
        CODTRASP_RSE = line.Substring(64, 40).Trim()
        CODTRASP_IND = line.Substring(104, 50).Trim()
        CODTRASP_CAP = line.Substring(154, 5).Trim()
        CODTRASP_LOC = line.Substring(159, 50).Trim()
        CODTRASP_TEL = line.Substring(209, 15).Trim()
        ODTRASP_TLX = line.Substring(224, 10).Trim()
        CODTRASP_FAX = line.Substring(234, 10).Trim()
        CODTRASP_EMAIL1 = line.Substring(244, 50).Trim()
        CODTRASP_EMAIL2 = line.Substring(294, 50).Trim()
        CODTRASP_EMAIL3 = line.Substring(344, 50).Trim()
        CODTRASP_DTPC = line.Substring(394, 8).Trim()
    End Sub
    Friend TRK As String
    Friend ODTRASP_TLX As String
    Friend CODTRASP As String
    Friend CODTRASP_TE1 As String
    Friend CODTRASP_TE2 As String
    Friend CODTRASP_TE3 As String
    Friend CODTRASP_TE4 As String
    Friend CODTRASP_TE5 As String
    Friend CODTRASP_RS As String
    Friend CODTRASP_RSE As String
    Friend CODTRASP_IND As String
    Friend CODTRASP_CAP As String
    Friend CODTRASP_LOC As String
    Friend CODTRASP_TEL As String
    Friend CODTRASP_TLX As String
    Friend CODTRASP_FAX As String
    Friend CODTRASP_EMAIL1 As String
    Friend CODTRASP_EMAIL2 As String
    Friend CODTRASP_EMAIL3 As String
    Friend CODTRASP_DTPC As String
End Class
Public Class Mit
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        SIGLA = line.Substring(3, 2).Trim()
        DES_MAG = line.Substring(5, 30).Trim()
        IND_MAG = line.Substring(35, 30).Trim()
        LOC_MAG = line.Substring(65, 20).Trim()
        CODFG070 = line.Substring(85, 6).Trim()
        RAGSOC_CLI = line.Substring(91, 50).Trim()
        RAGSOC_E_CLI = line.Substring(141, 40).Trim()
        BANCA_CLI = line.Substring(181, 35).Trim()
        TELEFONO_CLI = line.Substring(216, 15).Trim()
        TELEX_CLI = line.Substring(231, 10).Trim()
        FAX_CLI = line.Substring(241, 10).Trim()
        IND_CLI = line.Substring(251, 50).Trim()
        CAP_CLI = line.Substring(301, 5).Trim()
        LOC_CLI = line.Substring(306, 50).Trim()
        PROV_CLI = line.Substring(356, 3).Trim()
        CODFISC_CLI = line.Substring(359, 16).Trim()
        PARTIVA_CLI = line.Substring(375, 11).Trim()
        TELEX_CLI1 = line.Substring(386, 15).Trim()
        FAX_CLI1 = line.Substring(401, 15).Trim()
        TEL_MAG = line.Substring(416, 15).Trim()
        TELEX_MAG = line.Substring(431, 15).Trim()
        FAX_MAG = line.Substring(446, 15).Trim()
    End Sub
    Friend TRK As String
    Friend SIGLA As String
    Friend LOC_CLI As String
    Friend DES_MAG As String
    Friend IND_MAG As String
    Friend LOC_MAG As String
    Friend CODFG070 As String
    Friend RAGSOC_CLI As String
    Friend RAGSOC_E_CLI As String
    Friend BANCA_CLI As String
    Friend TELEFONO_CLI As String
    Friend TELEX_CLI As String
    Friend FAX_CLI As String
    Friend IND_CLI As String
    Friend CAP_CLI As String
    Friend OC_CLI As String
    Friend PROV_CLI As String
    Friend CODFISC_CLI As String
    Friend PARTIVA_CLI As String
    Friend TELEX_CLI1 As String
    Friend FAX_CLI1 As String
    Friend TEL_MAG As String
    Friend TELEX_MAG As String
    Friend FAX_MAG As String
End Class

'TO DO fare pull di Tg094.vb pc nuovo'
'Arrivato a pagina 288 tg904.txt'

Public Class Dett
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        SCHEMA = line.Substring(3, 4).Trim()
        NART_ORD_D = line.Substring(7, 10).Trim()
        NART_ORD_OM_D = line.Substring(17, 10).Trim()
        NART_CON_D = line.Substring(27, 10).Trim()
        NART_CON_OM_D = line.Substring(37, 10).Trim()
        CART_ORD_D = line.Substring(47, 10).Trim()
        CART_ORD_OM_D = line.Substring(57, 10).Trim()
        CART_CON_D = line.Substring(67, 10).Trim()
        CART_CON_OM_D = line.Substring(77, 10).Trim()
        PLT_ORD_D = line.Substring(87, 8).Trim()
        PLT_CON_D = line.Substring(95, 8).Trim()
        FORM_PLT_FORN = line.Substring(103, 20).Trim()
        CART_STRATO_FOR = line.Substring(103, 4).Trim()
        NUM_STRATO_FOR = line.Substring(107, 4).Trim()
        QTA_FORN_FOR = line.Substring(111, 4).Trim()
        QTA_TERMO_FOR = line.Substring(115, 4).Trim()
        NOTE_ORD_D = line.Substring(123, 80).Trim()
        PNT_CAR = line.Substring(203, 8).Trim()
        STATO_RIG = line.Substring(211, 1).Trim()
    End Sub

    Friend TRK As String
    Friend CART_ORD_D As String
    Friend QTA_FORN_FOR As String
    Friend PLT_ORD_D As String
    Friend SCHEMA As String
    Friend NART_ORD_D As String
    Friend NART_ORD_OM_D As String
    Friend NART_CON_D As String
    Friend NART_CON_OM_D As String
    Friend ART_ORD_D As String
    Friend CART_ORD_OM_D As String
    Friend CART_CON_D As String
    Friend CART_CON_OM_D As String
    Friend PLT_CON_D As String 'Arrivato a linea 235 file tg094.txt'
    Friend FORM_PLT_FORN As String
    Friend CART_STRATO_FOR As String
    Friend NUM_STRATO_FOR As String
    Friend QT_FOR_For As String
    Friend QTA_TERMO_FOR As String
    Friend NOTE_ORD_D As String
    Friend PNT_CAR As String
    Friend STATO_RIG As String
    Friend FIMB As String
End Class
'Arrivato riga 248'
Public Class Pro
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        CODPRO = line.Substring(3, 12).Trim()
        DES_PRO = line.Substring(15, 50).Trim()
        BCODE = line.Substring(65, 14).Trim()
        TIPO = line.Substring(79, 1).Trim()
        PUM = line.Substring(80, 8).Trim()
        PUM_UM = line.Substring(80, 2).Trim()
        PUM_QTA = line.Substring(82, 6).Trim()
        GR = line.Substring(88, 2).Trim()
        PESO_PRO = line.Substring(90, 6).Trim()
        DIM_PRO = line.Substring(96, 12).Trim()
        DIM_LATO1_PRO = line.Substring(96, 4).Trim()
        DIM_LATO2_PRO = line.Substring(100, 4).Trim()
        DIM_LATO3_PRO = line.Substring(104, 4).Trim()
        PNT_SC_CAR = line.Substring(108, 6).Trim()
        FORMA = line.Substring(114, 3).Trim()
        DURATA = line.Substring(117, 4).Trim()
        QTA_BCODE = line.Substring(121, 4).Trim()
        QTA_FORN = line.Substring(125, 6).Trim()
        QTA_TERMO = line.Substring(131, 6).Trim()
        FORM_PLT_MAG = line.Substring(137, 8).Trim()
        CART_STRATO_MAG = line.Substring(137, 4).Trim()
        NUM_STRATO_MAG = line.Substring(141, 4).Trim()
        QTA_VENDITA = line.Substring(145, 6).Trim()
        PESO_UVC = line.Substring(151, 6).Trim()
        DIM_UVC = line.Substring(157, 12).Trim()
        Dim_LATO1_UVC = line.Substring(157, 4).Trim()
        DIM_LATO2_UVC = line.Substring(161, 4).Trim()
        DIM_LATO3_UVC = line.Substring(165, 4).Trim()
        VARIETA = line.Substring(170, 10).Trim()
        NAZORI = line.Substring(180, 4).Trim()
        LOCAL = line.Substring(184, 5).Trim()
        CALIBRO = line.Substring(189, 7).Trim()
        CATEG = line.Substring(196, 2).Trim()
        TCONF = line.Substring(198, 4).Trim()
        TIMB = line.Substring(202, 3).Trim()
        FIMB = line.Substring(205, 1).Trim()
        UM = line.Substring(206, 2).Trim()
        CODIVA = line.Substring(208, 3).Trim()
        ALIQ = line.Substring(211, 4).Trim()
        CODF_TV = line.Substring(215, 200) 'Arrivato riga 288 file tg904.txt'   .Trim()
        CODF_E = line.Substring(215, 200).Trim()
        CODF = line.Substring(215, 20) 'Devo inserire questo campo?'            .Trim()
        PG_LIST = line.Substring(415, 4).Trim()
        RG_LIST = line.Substring(419, 2).Trim()
        P_BUYER = line.Substring(421, 4).Trim()
        P_DES_BUYER = line.Substring(425, 8).Trim()
        BCODE_IMB = line.Substring(433, 14).Trim()
        QTA_BCODE_IMB = line.Substring(447, 4).Trim()
        DTSCAD1 = line.Substring(451, 8).Trim()
        DTSCAD2 = line.Substring(459, 8).Trim()
        ART62 = line.Substring(467, 1).Trim()
        RE5 = line.Substring(468, 10).Trim()
        LNF = line.Substring(478, 2).Trim()
        BCODA = line.Substring(480, 30).Trim()
        DTINS_BCODE = line.Substring(510, 8).Trim()
        DTINS_BCODE_IMB = line.Substring(518, 8).Trim()
        DTINS_BCODA = line.Substring(526, 8).Trim()
        GR1 = line.Substring(534, 2).Trim()
        GR2 = line.Substring(536, 2).Trim()
        GR3 = line.Substring(538, 2).Trim()
        GR4 = line.Substring(540, 2).Trim()
        GR5 = line.Substring(542, 2)
    End Sub

    Friend TRK As String
    Friend CODPRO As String
    Friend FIMB As String
    Friend RG_LIST As String
    Friend NUM_STRATO_MAG As String
    Friend DES_PRO As String
    Friend BCODE As String
    Friend TIPO As String
    Friend PUM As String
    Friend PUM_UM As String
    Friend PUM_QTA As String
    Friend GR As String
    Friend PESO_PRO As String
    Friend DIM_PRO As String
    Friend DIM_LATO1_PRO As String
    Friend DIM_LATO2_PRO As String
    Friend DIM_LATO3_PRO As String
    Friend PNT_SC_CAR As String
    Friend FORMA As String
    Friend DURATA As String
    Friend QTA_BCODE As String
    Friend QTA_FORN As String
    Friend QTA_TERMO As String
    Friend FORM_PLT_MAG As String
    Friend CART_STRATO_MAG As String
    Friend QTA_VENDITA As String
    Friend PESO_UVC As String
    Friend DIM_UVC As String
    Friend Dim_LATO1_UVC As String
    Friend DIM_LATO2_UVC As String
    Friend DIM_LATO3_UVC As String
    Friend VARIETA As String
    Friend NAZORI As String
    Friend LOCAL As String
    Friend CALIBRO As String
    Friend CATEG As String
    Friend TCONF As String
    Friend TIMB As String
    Friend _FIMB As String
    Friend UM As String
    Friend CODIVA As String
    Friend ALIQ As String
    Friend CODF_TV As String
    Friend CODF_E As String
    Friend CODF As String
    Friend PG_LIST As String
    Friend P_BUYER As String
    Friend P_DES_BUYER As String
    Friend BCODE_IMB As String
    Friend QTA_BCODE_IMB As String
    Friend DTSCAD1 As String
    Friend DTSCAD2 As String
    Friend ART62 As String
    Friend RE5 As String
    Friend LNF As String
    Friend BCODA As String
    Friend DTINS_BCODE As String
    Friend DTINS_BCODE_IMB As String
    Friend DTINS_BCODA As String
    Friend GR1 As String
    Friend GR2 As String
    Friend GR3 As String
    Friend GR4 As String
    Friend GR5 As String
End Class
Public Class Xna_Xft
    Friend TRK
    Friend TG904_XVAL As String
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        TG904_XVAL = line.Substring(4, 16).Trim()
    End Sub
End Class

Public Class CO
    Public Sub New()
    End Sub
    Public Sub New(colStr As String, index As Integer)
        TRK = "CO" & index
        COS = colStr.Substring(3, 12).Trim()
        COSV = colStr.Substring(3, 12).Trim()
        STRINGA = colStr.Substring(15, 136).Trim()
    End Sub
    Friend TRK As String
    Friend COS As String
    Friend COSV As String
    Friend STRINGA As String
End Class
Public Class EndTr
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        TG904_NRK = line.Substring(4, 6).Trim()
    End Sub
    Friend TG904_NRK As String
    Friend TRK As String
End Class
Public Class PPI_PPT
    Friend TRK As String
    Friend PP_IMP As String
    Friend PP_IMPV As String
    Friend PP_IVA As String
    Friend PP_IVAV As String
    Friend PP_ALIQ As String
    Friend PP_CODIVA As String
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        PP_IMP = line.Substring(3, 14).Trim()
        PP_IMPV = line.Substring(3, 14).Trim()
        PP_IVA = line.Substring(17, 14).Trim()
        PP_IVAV = line.Substring(17, 14).Trim() 'Devo aggiungere questo Campo?' 
        PP_ALIQ = line.Substring(31, 4).Trim()
        PP_CODIVA = line.Substring(35, 3).Trim()
    End Sub
End Class










