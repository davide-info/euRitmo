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
    '''<<<<<<< HEAD
    Friend ppi As PPI_PPT
    Friend xna As Xna_Xft

    '''<<<<<<< HEAD

    Public Sub setend(endtr As EndTr)
        Me.endtr = endtr


    End Sub


    Public Function getEnd() As EndTr
        Return endtr

    End Function



    ''Friend ppi As PPI_PPT
    Friend ppt As PPI_PPT

    ' Friend xna As Xna_Xft
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
        SCHEMA = line.Substring(3, 4)
        NART_ORD_D = line.Substring(7, 10)
        NART_ORD_OM_D = line.Substring(17, 10)
        NART_CON_D = line.Substring(27, 10)
        NART_ORD_OM_D = line.Substring(37, 10)
        CART_OR_D = line.Substring(47, 10)
        CART_ORD_OM_D = line.Substring(57, 10)
        PLT_ORD_D = line.Substring(67, 10)
        PLT_CON_D = line.Substring(77, 10)
        FORM_PLT_FORN = line.Substring(87, 8)
        CART_STRATO_FOR = line.Substring(95, 8)
        QTA_FORN_FOR = line.Substring(103, 20)
        NOTE_ORD_D = line.Substring(123, 80)
        PNT_CAR = line.Substring(203, 8)
        STATO_RIG = line.Substring(211, 1)
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
        ''MessageBox.Show("TES " & stringTes)


        TRK = stringTes.Substring(0, 3)
        OP = stringTes.Substring(3, 1)
        TMOPE = stringTes.Substring(12, 8)
        ORD = stringTes.Substring(20, 10)
        DTORD = stringTes.Substring(30, 8)
        MAG = stringTes.Substring(38, 2)
        CODFOR = stringTes.Substring(40, 6)
        DTPC = stringTes.Substring(46, 8)
        CMPT = stringTes.Substring(54, 4)
        STATO_ORD = stringTes.Substring(58, 1)
        COD_BUYER = stringTes.Substring(59, 4)
        DES_BUYER = stringTes.Substring(63, 8)
        NART_ORD_T = stringTes.Substring(71, 8) 'Togliamo il segno?'
        NART_CON_T = stringTes.Substring(77, 6)
        CART_ORD_T = stringTes.Substring(83, 10)
        CART_ORD_OM_T = stringTes.Substring(93, 10)
        CART_CON_T = stringTes.Substring(103, 10)
        CART_CON_OM_T = stringTes.Substring(113, 10)
        PLT_ORD_T = stringTes.Substring(123, 8)
        PLT_CON_T = stringTes.Substring(131, 8)
        VAL_ORD_T = stringTes.Substring(139, 14)
        NOTE_ORD_T = stringTes.Substring(153, 80)
        SC_ORD_T = stringTes.Substring(233, 6)
        DTCON = stringTes.Substring(239, 8)
        DTDOC = stringTes.Substring(247, 8)
        NDOC = stringTes.Substring(255, 11)
        CAU = stringTes.Substring(266, 4)
        CAU_DES = stringTes.Substring(270, 30)
        TRANS = stringTes.Substring(300, 10)
        DESOP = stringTes.Substring(310, 30)
        EDI_MITT1 = stringTes.Substring(340, 35)
        EDI_MITT2 = stringTes.Substring(375, 4)
        EDI_DEST1 = stringTes.Substring(379, 35)
        EDI_DEST2 = stringTes.Substring(414, 4)
        FHH = stringTes.Substring(418, 4)
        FHH_DES = stringTes.Substring(422, 30)
        FHH_TMI_HH = stringTes.Substring(452, 2)
        FHH_TMI_MM = stringTes.Substring(454, 2)
        FHH_TMF_HH = stringTes.Substring(456, 2)
        FHH_TMF_MM = stringTes.Substring(458, 2)
        MTO_IND = stringTes.Substring(460, 50)
        FAX_NUM = stringTes.Substring(510, 20)
        NOME_BUYER = stringTes.Substring(530, 30)
        CGNM_BUYER = stringTes.Substring(560, 30)
        CELL_BUYER = stringTes.Substring(590, 20)
        EMAIL_BUYER = stringTes.Substring(610, 60)
        ID_CNT = stringTes.Substring(670, 20)
        CPAG = stringTes.Substring(690, 4)
        CPAG_DES = stringTes.Substring(694, 30)
        NAS_CODFORN = stringTes.Substring(724, 35)
        NAS_QCODFORN = stringTes.Substring(759, 4)
        TEEDIUM = stringTes.Substring(763, 1)
        TEMEA = stringTes.Substring(764, 1)
        TEOM = stringTes.Substring(765, 1)

        ''MessageBox.Show("TG904_NART_ORD_T " & TG904_NART_ORD_T)


    End Sub











End Class
Public Class Forn

    Public Sub New()

    End Sub
    Public Sub New(line As String)
        '' MessageBox.Show("FORN " & line)
        TRK = line.Substring(0, 3)
        RAGSOC_For = line.Substring(3, 50)
        RAGSOC_E_FOR = line.Substring(53, 40)
        BANCA_FOR = line.Substring(93, 35)
        RAPP_TEL = line.Substring(128, 15)
        TELEX_FOR = line.Substring(143, 10)
        FAX_FOR = line.Substring(153, 10)
        RAPP = line.Substring(163, 35)
        RAPP_TEL = line.Substring(198, 15)
        CAPO_AREA = line.Substring(213, 35)
        CAPO_AREA_TEL = line.Substring(248, 15)
        DIR_COMM = line.Substring(263, 35)
        DIR_COMM_TEL = line.Substring(298, 15)
        COD_PAG1 = line.Substring(313, 3)
        COD_PAG2 = line.Substring(316, 3)
        COD_PAG3 = line.Substring(319, 3)
        NOTE1_FOR = line.Substring(322, 72)
        NOTE2_For = line.Substring(394, 72)
        IND_FOR = line.Substring(466, 50)
        CAP_FOR = line.Substring(516, 5)
        LOC_FOR = line.Substring(521, 50)
        PROV_FOR = line.Substring(571, 3)
        CODFISC_For = line.Substring(574, 16)
        '' MessageBox.Show("CODICE FISCALE FORNITORE " & CODFISC_For)
        PARTIVA_FOR = line.Substring(590, 11)
        ORA_PREF = line.Substring(601, 4)
        EMAIL1 = line.Substring(605, 50)
        '' MessageBox.Show("Email fornitore " & EMAIL1)
        EMAIL2 = line.Substring(655, 50)
        EMAIL3 = line.Substring(705, 50)
        WEB = line.Substring(755, 50)


        TELEX_FOR1 = line.Substring(805, 15)
        '' MessageBox.Show("Telex-for1 " & TELEX_FOR1)
        FAX_FOR1 = line.Substring(820, 15)
        COD_PAG = line.Substring(835, 3)
        COD_PAG_DES = line.Substring(838, 30)
        FG050_FLAG1 = line.Substring(868, 1)
        FG050_FLAG2 = line.Substring(869, 1)
        FG050_FLAG3 = line.Substring(870, 1)
        FG050_FLAG4 = line.Substring(871, 1)
        FG050_FLAG5 = line.Substring(872, 1)
        CODFORR = line.Substring(873, 6)

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
        '' MessageBox.Show("RUB " & line)
        TRK = line.Substring(0, 3)
        RUB_SERVIZIO = line.Substring(3, 8)
        RUB_IND = line.Substring(12, 200)

    End Sub

End Class
Public Class Pdv
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        '' MessageBox.Show("PDV " & line)
        TRK = line.Substring(0, 3)
        RAGSOC_PDV = line.Substring(3, 50)
        RAGSOC_E_PDV = line.Substring(53, 40)
        TELEFONO_PDV = line.Substring(93, 15)
        TELEX_PDV = line.Substring(108, 10)
        FAX_PDV = line.Substring(118, 10)
        IND_PDV = line.Substring(128, 50)
        CAP_PDV = line.Substring(178, 5)
        LOC_PDV = line.Substring(183, 50)
        PROV_PDV = line.Substring(233, 3)
        IND_BC_PDV = line.Substring(236, 50)
        CAP_BC_PDV = line.Substring(286, 5)
        LOC_BC_PDV = line.Substring(291, 50)
        PROV_BC_PDV = line.Substring(341, 3)
        CODFISC_PDV = line.Substring(344, 16)
        PARTIVA_PDV = line.Substring(360, 11)
        EMAIL1_PDV = line.Substring(371, 50)
        EMAIL2_PDV = line.Substring(421, 50)
        EMAIL3_PDV = line.Substring(471, 50)
        CODSEDEAMM_PDV = line.Substring(521, 6)
        CODSEDELEG_PDV = line.Substring(527, 6)
        COD_PDV = line.Substring(533, 6)

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
        ''    MessageBox.Show("TSP " & line)
        TRK = line.Substring(0, 3)
        CODTRASP = line.Substring(3, 6)
        CODTRASP_TE1 = line.Substring(9, 1)
        CODTRASP_TE2 = line.Substring(10, 1)
        CODTRASP_TE3 = line.Substring(11, 1)
        CODTRASP_TE4 = line.Substring(12, 1)
        CODTRASP_TE5 = line.Substring(13, 1)
        CODTRASP_RS = line.Substring(14, 50)
        CODTRASP_RSE = line.Substring(64, 40)
        CODTRASP_IND = line.Substring(104, 50)
        CODTRASP_CAP = line.Substring(154, 5)
        CODTRASP_LOC = line.Substring(159, 50)
        CODTRASP_TEL = line.Substring(209, 15)
        ODTRASP_TLX = line.Substring(224, 10)
        CODTRASP_FAX = line.Substring(234, 10)
        CODTRASP_EMAIL1 = line.Substring(244, 50)
        CODTRASP_EMAIL2 = line.Substring(294, 50)
        CODTRASP_EMAIL3 = line.Substring(344, 50)
        CODTRASP_DTPC = line.Substring(394, 8)


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
        ''   MessageBox.Show("MIT " & line)
        TRK = line.Substring(0, 3)
        SIGLA = line.Substring(3, 2)
        DES_MAG = line.Substring(5, 30)
        IND_MAG = line.Substring(35, 30)
        LOC_MAG = line.Substring(65, 20)
        CODFG070 = line.Substring(85, 6)
        RAGSOC_CLI = line.Substring(91, 50)
        RAGSOC_E_CLI = line.Substring(141, 40)
        BANCA_CLI = line.Substring(181, 35)
        TELEFONO_CLI = line.Substring(216, 15)
        TELEX_CLI = line.Substring(231, 10)
        FAX_CLI = line.Substring(241, 10)
        IND_CLI = line.Substring(251, 50)
        CAP_CLI = line.Substring(301, 5)
        LOC_CLI = line.Substring(306, 50)
        PROV_CLI = line.Substring(356, 3)
        CODFISC_CLI = line.Substring(359, 16)
        PARTIVA_CLI = line.Substring(375, 11)
        TELEX_CLI1 = line.Substring(386, 15)
        FAX_CLI1 = line.Substring(401, 15)
        TEL_MAG = line.Substring(416, 15)
        TELEX_MAG = line.Substring(431, 15)
        FAX_MAG = line.Substring(446, 15)

        ''  MessageBox.Show("Telefono CLI " & TELEFONO_CLI)
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
        MessageBox.Show("DET " & line)
        TRK = line.Substring(0, 3)
        SCHEMA = line.Substring(3, 4)
        NART_ORD_D = line.Substring(7, 10)
        NART_ORD_OM_D = line.Substring(17, 10)
        NART_CON_D = line.Substring(27, 10)
        NART_CON_OM_D = line.Substring(37, 10)
        CART_ORD_D = line.Substring(47, 10)
        CART_ORD_OM_D = line.Substring(57, 10)
        CART_CON_D = line.Substring(67, 10)
        CART_CON_OM_D = line.Substring(77, 10)
        PLT_ORD_D = line.Substring(87, 8)
        PLT_CON_D = line.Substring(95, 8)
        FORM_PLT_FORN = line.Substring(103, 20)
        CART_STRATO_FOR = line.Substring(103, 4)
        NUM_STRATO_FOR = line.Substring(107, 4)
        QTA_FORN_FOR = line.Substring(111, 4)
        QTA_TERMO_FOR = line.Substring(115, 4)
        NOTE_ORD_D = line.Substring(123, 80)
        PNT_CAR = line.Substring(203, 8)
        STATO_RIG = line.Substring(211, 1)

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
    Public Sub New(proStr As String)
        MessageBox.Show("PRO " & proStr)

        CODPRO = proStr.Substring(3, 12)

        DES_PRO = proStr.Substring(15, 50)

        BCODE = proStr.Substring(65, 14)

        TIPO = proStr.Substring(79, 1)

        PUM = proStr.Substring(80, 8)

        PUM_UM = proStr.Substring(80, 2)

        PUM_QTA = proStr.Substring(82, 6)

        GR = proStr.Substring(88, 2)

        PESO_PRO = proStr.Substring(90, 6)

        DIM_PRO = proStr.Substring(96, 12)

        DIM_LATO1_PRO = proStr.Substring(96, 4)

        DIM_LATO2_PRO = proStr.Substring(100, 4)

        DIM_LATO3_PRO = proStr.Substring(104, 4)

        PNT_SC_CAR = proStr.Substring(108, 6)

        FORMA = proStr.Substring(114, 3)

        DURATA = proStr.Substring(117, 4)

        QTA_BCODE = proStr.Substring(121, 4)

        QTA_FORN = proStr.Substring(125, 6)

        QTA_TERMO = proStr.Substring(131, 6)

        FORM_PLT_MAG = proStr.Substring(137, 8)

        CART_STRATO_MAG = proStr.Substring(137, 4)

        NUM_STRATO_MAG = proStr.Substring(141, 4)

        QTA_VENDITA = proStr.Substring(145, 6)

        PESO_UVC = proStr.Substring(151, 6)

        DIM_UVC = proStr.Substring(157, 12)

        Dim_LATO1_UVC = proStr.Substring(157, 4)

        DIM_LATO2_UVC = proStr.Substring(161, 4)
        DIM_LATO3_UVC = proStr.Substring(165, 4)
        VARIETA = proStr.Substring(170, 10)
        NAZORI = proStr.Substring(180, 4)
        LOCAL = proStr.Substring(184, 5)
        CALIBRO = proStr.Substring(189, 7)
        CATEG = proStr.Substring(196, 2)
        TCONF = proStr.Substring(198, 4)
        TIMB = proStr.Substring(202, 3)
        FIMB = proStr.Substring(205, 1)
        UM = proStr.Substring(206, 2)
        CODIVA = proStr.Substring(208, 3)
        ALIQ = proStr.Substring(211, 4)
        CODF_TV = proStr.Substring(215, 200) 'Arrivato riga 288 file tg904.txt'
        CODF_E = proStr.Substring(215, 200)
        CODF = proStr.Substring(215, 20) 'Devo inserire questo campo?'
        PG_LIST = proStr.Substring(415, 4)
        RG_LIST = proStr.Substring(419, 2)
        P_BUYER = proStr.Substring(421, 4)
        P_DES_BUYER = proStr.Substring(425, 8)
        BCODE_IMB = proStr.Substring(433, 14)
        QTA_BCODE_IMB = proStr.Substring(447, 4)
        DTSCAD1 = proStr.Substring(451, 8)
        DTSCAD2 = proStr.Substring(459, 8)
        ART62 = proStr.Substring(467, 1)
        RE5 = proStr.Substring(468, 10)
        LNF = proStr.Substring(478, 2)
        BCODA = proStr.Substring(480, 30)
        DTINS_BCODE = proStr.Substring(510, 8)
        DTINS_BCODE_IMB = proStr.Substring(518, 8)
        DTINS_BCODA = proStr.Substring(526, 8)
        GR1 = proStr.Substring(534, 2)
        GR2 = proStr.Substring(536, 2)
        GR3 = proStr.Substring(538, 2)
        GR4 = proStr.Substring(540, 2)
        GR5 = proStr.Substring(542, 2)

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
        ''  MessageBox.Show("XNA " & line)
        TRK = line.Substring(0, 3)
        TG904_XVAL = line.Substring(4, 16)
    End Sub



End Class

Public Class CO
    Public Sub New()

    End Sub
    Public Sub New(colStr As String, index As Integer)
        ''   MessageBox.Show("COL " & colStr)
        TRK = "CO" & index
        COS = colStr.Substring(3, 12)
        COSV = colStr.Substring(3, 12)
        STRINGA = colStr.Substring(15, 136)
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
        MessageBox.Show("ENDTR " & line)
        TRK = line.Substring(0, 3)
        TG904_NRK = line.Substring(4, 6)

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
        TRK = line.Substring(0, 3)
        PP_IMP = line.Substring(3, 14)
        PP_IMPV = line.Substring(3, 14)
        PP_IVA = line.Substring(17, 14)
        PP_IVAV = line.Substring(17, 14) 'Devo aggiungere questo Campo?' 
        PP_ALIQ = line.Substring(31, 4)
        PP_CODIVA = line.Substring(35, 3)




    End Sub
End Class










