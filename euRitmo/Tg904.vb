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
    Friend Dtope As Dtope
    Friend rub As Rub
    Friend forn As Forn
    Friend tsp As Tsp
    Friend pdv As Pdv
    Friend Pro As Pro
    Friend cols As List(Of Col)
    Friend mit As Mit
    Friend endtr As EndTr
    Public Sub setend(endtr As EndTr)
        Me.endtr = endtr


    End Sub


    Public Function getEnd() As EndTr
        Return endtr

    End Function
    Public Overrides Function Tostring() As String
        Dim str = ""



        If Not IsNothing(Tes) Then

            str = Tes.Tostring
        End If
        Return str
    End Function



    Public Sub setDtope(dtope As Dtope)
        Me.Dtope = dtope

    End Sub
    Public Property TesProp As Tes
        Set(value As Tes)
            If (Not IsNothing(value)) Then
                '' MessageBox.Show("vero")

                Tes = value
            End If


        End Set
        Get
            Return Tes
        End Get
    End Property



    Public Sub setRub(rub As Rub)
        Me.rub = rub
    End Sub
    Public Sub setPdv(pdv As Pdv)
        Me.pdv = pdv
    End Sub

    Public Function getRub() As Rub
        Return rub
    End Function
    Public Sub setmit(mit As Mit)
        Me.mit = mit
    End Sub
    Public Function getMit() As Mit
        Return mit
    End Function
    Public Function getDtope() As Dtope
        Return Dtope
    End Function
    Public Sub setCols(cols As List(Of Col))
        Me.cols = cols
    End Sub
    Public Function getCols() As List(Of Col)
        Return cols
    End Function

    Friend Sub setTes(Tes As Tes)
        Me.Tes = Tes

    End Sub
    Public Function getTes() As Tes
        Return Tes
    End Function
    Public Sub setForn(forn As Forn)
        Me.forn = forn
    End Sub
    Public Function getForn() As Forn
        Return forn
    End Function

    Friend Sub setpro(pro As Pro)
        Me.Pro = pro
    End Sub
End Class

Public Class Dtope

    Public Sub New()

    End Sub
    Public Sub New(dtopeStr As String)
        MessageBox.Show("DTOPE " & dtopeStr)

    End Sub

    Friend DTOPE_SAA As String
    Friend DTOPE_MM As String
    Friend DTOPE_GG As String
    Public Sub setDtopeMM(DTOPE_MM As String)
        Me.DTOPE_MM = DTOPE_MM



    End Sub
    Public Function getDtopeMM() As String
        Return Me.DTOPE_MM


    End Function

    Public Sub setDtopseSaa(DTOPE_SAA As String)
        Me.DTOPE_SAA = DTOPE_SAA


    End Sub
    Public Function GetDtopeSaa() As String
        Return Me.DTOPE_SAA

    End Function


End Class
Public Class Tes


    Friend TG904_TRK As String
    Public Sub setTG904_TRK(TG904_TRK As String)
        Me.TG904_TRK = TG904_TRK


    End Sub

    Public Overrides Function Tostring() As String
        Return Me.TG904_TRK.ToString & Me.TG904_PLT_CON_T.ToString

    End Function

    Public Function getTG904_TRK()
        Return TG904_TRK
    End Function

    Friend TG904_OP As String
    Public Sub setTG904_OP(TG904_OP As String)
        Me.TG904_OP = TG904_OP

    End Sub
    Public Function getTG904_OP() As String
        Return TG904_OP
    End Function

    Friend TG904_TMOPE As String
    Public Sub setTG904_TMOPE(TG904_TMOPE As String)
        Me.TG904_TMOPE = TG904_TMOPE
    End Sub
    Public Function getTG904_TMOPE() As String
        Return Me.TG904_TMOPE
    End Function
    Friend TG904_DTPC As String
    Public Sub setTG904_DTCP(TG94_DTCP As String)
        Me.TG904_DTPC = TG904_DTPC
    End Sub
    Public Function getTG904_DTCP() As String
        Return TG904_DTPC
    End Function

    Friend TG904_CMPT As String
    Public Sub setTG904_CMPT(TG904_CMPT As String)
        Me.TG904_CMPT = TG904_CMPT

    End Sub
    Public Function getTG904_CMPT() As String
        Return TG904_CMPT
    End Function
    Friend TG904_STATO_ORD As String
    Public Sub setTG904_STATO_ORD(TG904_STATO_ORD As String)
        Me.TG904_STATO_ORD = TG904_STATO_ORD


    End Sub
    Public Function getTG904_STATO_ORD() As String
        Return TG904_STATO_ORD

    End Function

    Friend TG904_COD_BUYER As String
    Public Sub setTG904_COD_BUYER(TG904_COD_BUYER As String)
        Me.TG904_COD_BUYER = TG904_COD_BUYER


    End Sub
    Public Function getTG904_COD_BUYER() As String
        Return TG904_COD_BUYER

    End Function


    Friend TG904_DES_BUYER As String
    Public Sub setTG904_DES_BUYER(TG904_DES_BUYER As String)
        Me.TG904_DES_BUYER = TG904_DES_BUYER

    End Sub
    Public Function getTG904_DES_BUYER() As String
        Return Me.TG904_DES_BUYER


    End Function

    Friend TG904_NART_ORD_T As String
    Public Sub setTG904_NART_ORD_T(TG904_NART_ORD_T As String)
        Me.TG904_NART_ORD_T = TG904_NART_ORD_T


    End Sub


    Friend TG904_NART_CON_T As String
    Public Sub setTG904_NART_CON_T(TG904_NART_CON_T As String)
        Me.TG904_NART_CON_T = TG904_NART_CON_T


    End Sub

    Friend TG904_CART_ORD_OMT_T As String
    Public Sub setTG904_CART_ORD_OMT_T(TG904_CART_ORD_OMT_T As String)
        Me.TG904_CART_ORD_OMT_T = TG904_CART_ORD_OMT_T


    End Sub
    Public Function getTG904_CART_ORD_OMT_T() As String
        Return Me.TG904_CART_ORD_OMT_T

    End Function
    Friend TG904_CART_CON_T As String
    Public Sub setTG904_CART_CON_T(TG904_CART_CON_T As String)
        Me.TG904_CART_CON_T = TG904_CART_CON_T


    End Sub

    Public Function getTG904_CART_CON_T() As String
        Return TG904_CART_CON_T

    End Function

    Friend TG904_CART_CON_OM_T As String
    Public Sub setTG904_CART_CON_OM_T(TG904_CART_CON_OM_T As String)
        Me.TG904_CART_CON_OM_T = TG904_CART_CON_OM_T



    End Sub
    Public Function getTG904_CART_CON_OM_T() As String
        Return TG904_CART_CON_OM_T

    End Function

    Friend TG904_PLT_ORD_T As String
    Public Sub setTG904_PLT_ORD_T(TG904_PLT_ORD_T As String)
        Me.TG904_PLT_ORD_T = TG904_PLT_ORD_T


    End Sub
    Public Function getTG904_PLT_ORD_T() As String
        Return TG904_PLT_ORD_T

    End Function


    Friend TG904_PLT_CON_T As String
    Public Sub setTG904_PLT_CON_T(TG904_PLT_CON_T As String)
        Me.TG904_PLT_CON_T = TG904_PLT_CON_T


    End Sub
    Public Function getTG904_PLT_CON_T() As String
        Return TG904_PLT_CON_T

    End Function

    Friend TG904_VAL_ORD_T As String
    Friend Sub setTG904_VAL_ORD_T(TG904_VAL_ORD_T As String)
        Me.TG904_VAL_ORD_T = TG904_VAL_ORD_T


    End Sub
    Public Function getTG904_VAL_ORD_T() As String
        Return TG904_VAL_ORD_T
    End Function

    Friend TG904_NOTE_ORD_T As String
    Public Sub setTG904_NOTE_ORD_T(TG904_NOTE_TG904_VAL_ORD_T As String)
        Me.TG904_NOTE_ORD_T = TG904_NOTE_ORD_T


    End Sub
    Public Function GetTG904_NOTE_ORD_T() As String
        Return TG904_NOTE_ORD_T
    End Function

    Friend TG904_SC_ORD_T As String
    Public Sub setTG904_SC_ORD_T(TG904_SC_ORD_T As String)
        Me.TG904_SC_ORD_T = TG904_SC_ORD_T


    End Sub
    Public Function getTG904_SC_ORD_T() As String
        Return TG904_SC_ORD_T
    End Function
    Friend TG904_DTCON As String
    Public Sub setTG90_DTCON(TG904_DTCON As String)
        Me.TG904_DTCON = TG904_DTCON
    End Sub
    Public Function getTG90_DTCON() As String
        Return TG904_DTCON
    End Function

    Friend TG904_DTDOC As String
    Public Sub setTG904_DTDOC(TG904_DTDOC As String)
        Me.TG904_DTDOC = TG904_DTDOC


    End Sub
    Public Function getTG904_DTDOC() As String
        Return TG904_DTDOC
    End Function

    Public Sub New()

    End Sub
    Friend TG904_ORD As String
    Friend Tg904_DTORD As String
    Friend TG904_MAG As String
    Friend TG904_CODFOR As String
    Friend TG904_CART_ORD_T As String
    Friend TG904_CART_ORD_OM_T As String
    Friend TG904_NDOC As String
    Friend TG904_CAU As String
    Friend TG904_CAU_DES As String
    Friend TG904_TRANS As String
    Friend TG904_DESOP As String
    Friend TG904_EDI_MITT1 As String
    Friend Tg904_EDI_MITT2 As String
    Friend TG904_EDI_DEST1 As String
    Friend TG904_EDI_DEST2 As String
    Friend TG904_FHH As String
    Friend TG904_FHH_DES As String
    Friend TG904_FHH_TMI_HH As String
    Friend Tg904_FHH_TMI_MM As String
    Friend TG904_FHH_TMF_HH As String
    Friend TG904_FHH_TMF_MM As String
    Friend Tg904_MTO_IND As String
    Friend TG904_FAX_NUM As String
    Friend TG904_NOME_BUYER As String
    Friend TG904_CGNM_BUYER As String
    Friend Tg904_CELL_BUYER As String
    Friend Tg904_EMAIL_BUYER As String
    Friend Tg904_ID_CNT As String
    Friend TG904_CPAG As String
    Friend TG904_CPAG_DES As String
    Friend TG904_NAS_CODFORN As String
    Friend TG904_NAS_QCODFORN As String
    Friend Tg904_TEEDIUM As String
    Friend Tg904_TEMEA As String
    Friend TG904_TEOM As String
    Public Sub New(ByVal stringTes As String)
        MessageBox.Show("TES " & stringTes)

        TG904_TRK = stringTes.Substring(0, 3)
        TG904_OP = stringTes.Substring(3, 1)
        TG904_TMOPE = stringTes.Substring(12, 8)
        TG904_ORD = stringTes.Substring(20, 10)
        Tg904_DTORD = stringTes.Substring(30, 8)
        TG904_MAG = stringTes.Substring(38, 2)
        TG904_CODFOR = stringTes.Substring(40, 6)
        TG904_DTPC = stringTes.Substring(46, 8)
        TG904_CMPT = stringTes.Substring(54, 4)
        TG904_STATO_ORD = stringTes.Substring(58, 1)
        TG904_COD_BUYER = stringTes.Substring(59, 4)
        TG904_DES_BUYER = stringTes.Substring(63, 8)
        TG904_NART_ORD_T = stringTes.Substring(71, 8) 'Togliamo il segno?'
        TG904_NART_CON_T = stringTes.Substring(77, 6)
        TG904_CART_ORD_T = stringTes.Substring(83, 10)
        TG904_CART_ORD_OM_T = stringTes.Substring(93, 10)
        TG904_CART_CON_T = stringTes.Substring(103, 10)
        TG904_CART_CON_OM_T = stringTes.Substring(113, 10)
        TG904_PLT_ORD_T = stringTes.Substring(123, 8)
        TG904_PLT_CON_T = stringTes.Substring(131, 8)
        TG904_VAL_ORD_T = stringTes.Substring(139, 14)
        TG904_NOTE_ORD_T = stringTes.Substring(153, 80)
        TG904_SC_ORD_T = stringTes.Substring(233, 6)
        TG904_DTCON = stringTes.Substring(239, 8)
        TG904_DTDOC = stringTes.Substring(247, 8)
        TG904_NDOC = stringTes.Substring(255, 11)
        TG904_CAU = stringTes.Substring(266, 4)
        TG904_CAU_DES = stringTes.Substring(270, 30)
        TG904_TRANS = stringTes.Substring(300, 10)
        TG904_DESOP = stringTes.Substring(310, 30)
        TG904_EDI_MITT1 = stringTes.Substring(340, 35)
        Tg904_EDI_MITT2 = stringTes.Substring(375, 4)
        TG904_EDI_DEST1 = stringTes.Substring(379, 35)
        TG904_EDI_DEST2 = stringTes.Substring(414, 4)
        TG904_FHH = stringTes.Substring(418, 4)
        TG904_FHH_DES = stringTes.Substring(422, 30)
        TG904_FHH_TMI_HH = stringTes.Substring(452, 2)
        Tg904_FHH_TMI_MM = stringTes.Substring(454, 2)
        TG904_FHH_TMF_HH = stringTes.Substring(456, 2)
        TG904_FHH_TMF_MM = stringTes.Substring(458, 2)
        Tg904_MTO_IND = stringTes.Substring(460, 50)
        TG904_FAX_NUM = stringTes.Substring(510, 20)
        TG904_NOME_BUYER = stringTes.Substring(530, 30)
        TG904_CGNM_BUYER = stringTes.Substring(560, 30)
        Tg904_CELL_BUYER = stringTes.Substring(590, 20)
        Tg904_EMAIL_BUYER = stringTes.Substring(610, 60)
        Tg904_ID_CNT = stringTes.Substring(670, 20)
        TG904_CPAG = stringTes.Substring(690, 4)
        TG904_CPAG_DES = stringTes.Substring(694, 30)
        TG904_NAS_CODFORN = stringTes.Substring(724, 35)
        TG904_NAS_QCODFORN = stringTes.Substring(759, 4)
        Tg904_TEEDIUM = stringTes.Substring(763, 1)
        Tg904_TEMEA = stringTes.Substring(764, 1)
        TG904_TEOM = stringTes.Substring(765, 1)

        ''MessageBox.Show("TG904_NART_ORD_T " & TG904_NART_ORD_T)


    End Sub











End Class
Public Class Forn

    Public Sub New()

    End Sub
    Public Sub New(stringForn As String)
        MessageBox.Show("FORN " & stringForn)
        TG904_RAGSOC_For = stringForn.Substring(3, 50)
        TG904_RAGSOC_E_FOR = stringForn.Substring(53, 40)
        TG904_BANCA_FOR = stringForn.Substring(93, 35)
        TG904_RAPP_TEL = stringForn.Substring(128, 15)
        TG904_TELEX_FOR = stringForn.Substring(143, 10)
        TG904_FAX_FOR = stringForn.Substring(153, 10)
        TG904_RAPP = stringForn.Substring(163, 35)
        TG904_RAPP_TEL = stringForn.Substring(198, 15)
        TG904_CAPO_AREA = stringForn.Substring(213, 35)
        TG904_CAPO_AREA_TEL = stringForn.Substring(248, 15)
        TG904_DIR_COMM = stringForn.Substring(263, 35)
        TG904_DIR_COMM_TEL = stringForn.Substring(298, 15)
        TG904_COD_PAG1 = stringForn.Substring(313, 3)
        TG904_COD_PAG2 = stringForn.Substring(316, 3)
        TG904_COD_PAG3 = stringForn.Substring(319, 3)
        TG904_NOTE1_FOR = stringForn.Substring(322, 72)
        TG904_NOTE2_For = stringForn.Substring(394, 72)
        TG904_IND_FOR = stringForn.Substring(466, 50)
        TG904_CAP_FOR = stringForn.Substring(516, 5)
        TG904_LOC_FOR = stringForn.Substring(521, 50)
        TG904_PROV_FOR = stringForn.Substring(571, 3)
        TG904_CODFISC_For = stringForn.Substring(574, 16)
        ''MessageBox.Show("CODICE FISCALE FORNITORE " & TG904_CODFISC_For)
        TG904_PARTIVA_FOR = stringForn.Substring(590, 11)
        TG904_ORA_PREF = stringForn.Substring(601, 4)
        TG904_EMAIL1 = stringForn.Substring(605, 50)
        '' MessageBox.Show("Email fornitore " & TG904_EMAIL1)
        TG904_EMAIL2 = stringForn.Substring(655, 50)
        TG904_EMAIL3 = stringForn.Substring(705, 50)
        TG904_WEB = stringForn.Substring(755, 50)


        TG904_TELEX_FOR1 = stringForn.Substring(805, 15)
        ''  MessageBox.Show("Telex-for1 " & TG904_TELEX_FOR1)
        TG904_FAX_FOR1 = stringForn.Substring(820, 15)
        TG904_COD_PAG = stringForn.Substring(835, 3)
        TG904_COD_PAG_DES = stringForn.Substring(838, 30)
        TG904_FG050_FLAG1 = stringForn.Substring(868, 1)
        TG904_FG050_FLAG2 = stringForn.Substring(869, 1)
        TG904_FG050_FLAG3 = stringForn.Substring(870, 1)
        TG904_FG050_FLAG4 = stringForn.Substring(871, 1)
        TG904_FG050_FLAG5 = stringForn.Substring(872, 1)
        TG904_CODFORR = stringForn.Substring(873, 6)

    End Sub

    Friend TG904_RAGSOC_For As String
    Friend TG904_RAPP_TEL As String
    Public Sub setTG904_RAGSOC_For(TG904_RAGSOC_For As String)
        Me.TG904_RAGSOC_E_FOR = TG904_RAGSOC_For


    End Sub
    Public Function getTG904_RAGSOC_For() As String
        Return TG904_RAGSOC_For
    End Function

    Friend TG904_RAGSOC_E_FOR As String
    Public Sub setTG904_RAGSOC_E_FOR(TG904_RAGSOC_E_FOR As String)
        Me.TG904_RAGSOC_E_FOR = TG904_RAGSOC_E_FOR
    End Sub


    Friend TG904_BANCA_FOR As String
    Public Sub setTG904_BANCA_FOR(TG904_BANCA_FOR As String)
        Me.TG904_BANCA_FOR = TG904_BANCA_FOR
    End Sub
    Public Function getTG904_BANCA_FOR()
        Return TG904_BANCA_FOR
    End Function
    Friend TG904_TELEFONO_FOR As String
    Public Sub setTG904_TELEFONO_FOR(TG904_TELEFONO_FOR As String)
        Me.TG904_TELEFONO_FOR = TG904_TELEFONO_FOR
    End Sub
    Public Function getTG904_TELEFONO_FOR() As String
        Return TG904_TELEFONO_FOR
    End Function
    Friend TG904_TELEX_FOR As String
    Public Sub setTG904_TELEX_FOR(TG904_TELEX_FOR As String)
        Me.TG904_TELEX_FOR = TG904_TELEX_FOR
    End Sub
    Public Function getTG904_TELEX_FOR() As String
        Return TG904_TELEX_FOR
    End Function
    Friend TG904_FAX_FOR As String
    Public Sub setTG904_FAX_FOR(TG904_FAX_FOR As String)
        Me.TG904_FAX_FOR = TG904_FAX_FOR
    End Sub
    Public Function getTG904_FAX_FOR() As String
        Return TG904_FAX_FOR
    End Function
    Friend TG904_RAPP As String

    Public Sub setTG904_RAP(TG904_RAPP As String)
        Me.TG904_RAPP = TG904_RAPP
    End Sub
    Public Function getTG904_RAP() As String
        Return TG904_RAPP
    End Function

    Friend TG904_CAPO_AREA As String
    Friend TG904_CAPO_AREA_TEL As String
    Friend TG904_DIR_COMM As String
    Friend TG904_DIR_COMM_TEL As String
    Friend TG904_COD_PAG1 As String
    Friend TG904_COD_PAG2 As String
    Friend TG904_COD_PAG3 As String
    Friend TG904_NOTE1_FOR As String
    Friend TG904_NOTE2_For As String
    Friend TG904_IND_FOR As String
    Friend TG904_CAP_FOR As String
    Friend TG904_LOC_FOR As String
    Friend TG904_PROV_FOR As String
    Friend TG904_CODFISC_For As String
    Friend TG904_PARTIVA_FOR As String
    Friend TG904_ORA_PREF As String
    '' Friend TG904_HH_PREF As String
    '' Friend TG904_MM_PREF As String
    Friend TG904_EMAIL1 As String
    Friend TG904_EMAIL2 As String
    Friend TG904_EMAIL3 As String
    Friend TG904_WEB As String
    Friend TG904_TELEX_FOR1 As String
    Friend TG904_FAX_FOR1 As String
    Friend TG904_COD_PAG As String
    Friend TG904_COD_PAG_DES As String
    Friend TG904_FG050_FLAG1 As String
    Friend TG904_FG050_FLAG2 As String
    Friend TG904_FG050_FLAG3 As String
    Friend TG904_FG050_FLAG4 As String
    Friend TG904_FG050_FLAG5 As String
    Friend TG904_CODFORR As String
End Class
Public Class Rub
    Friend TG904_RUB_SERVIZIO As String
    Friend TG904_RUB_IND As String
    Public Sub New()

    End Sub
    Public Sub New(stringRub As String)
        MessageBox.Show("RUB " & stringRub)
        TG904_RUB_SERVIZIO = stringRub.Substring(3, 8)
        TG904_RUB_IND = stringRub.Substring(12, 200)

    End Sub

End Class
Public Class Pdv
    Public Sub New()

    End Sub
    Public Sub New(stringPdv As String)
        MessageBox.Show("PDV " & stringPdv)
        TG904_RAGSOC_PDV = stringPdv.Substring(3, 50)
        TG904_RAGSOC_E_PDV = stringPdv.Substring(53, 40)
        TG904_TELEFONO_PDV = stringPdv.Substring(93, 15)
        TG904_TELEX_PDV = stringPdv.Substring(108, 10)
        TG904_FAX_PDV = stringPdv.Substring(118, 10)
        TG904_IND_PDV = stringPdv.Substring(128, 50)
        TG904_CAP_PDV = stringPdv.Substring(178, 5)
        TG904_LOC_PDV = stringPdv.Substring(183, 50)
        TG904_PROV_PDV = stringPdv.Substring(233, 3)
        TG904_IND_BC_PDV = stringPdv.Substring(236, 50)
        TG904_CAP_BC_PDV = stringPdv.Substring(286, 5)
        TG904_LOC_BC_PDV = stringPdv.Substring(291, 50)
        TG904_PROV_BC_PDV = stringPdv.Substring(341, 3)
        TG904_CODFISC_PDV = stringPdv.Substring(344, 16)
        TG904_PARTIVA_PDV = stringPdv.Substring(360, 11)
        TG904_EMAIL1_PDV = stringPdv.Substring(371, 50)
        TG904_EMAIL2_PDV = stringPdv.Substring(421, 50)
        TG904_EMAIL3_PDV = stringPdv.Substring(471, 50)
        TG904_CODSEDEAMM_PDV = stringPdv.Substring(521, 6)
        TG904_CODSEDELEG_PDV = stringPdv.Substring(527, 6)
        TG904_COD_PDV = stringPdv.Substring(533, 6)

    End Sub

    Friend TG904_RAGSOC_PDV As String
    Friend TG904_RAGSOC_E_PDV As String
    Friend TG904_TELEFONO_PDV As String
    Friend TG904_TELEX_PDV As String
    Friend TG904_FAX_PDV As String
    Friend TG904_IND_PDV As String
    Friend TG904_CAP_PDV As String
    Friend TG904_LOC_PDV As String
    Friend TG904_PROV_PDV As String
    Friend TG904_IND_BC_PDV As String
    Friend TG904_CAP_BC_PDV As String
    Friend TG904_LOC_BC_PDV As String
    Friend TG904_PROV_BC_PDV As String
    Friend TG904_CODFISC_PDV As String
    Friend TG904_PARTIVA_PDV As String
    Friend TG904_EMAIL1_PDV As String
    Friend TG904_EMAIL2_PDV As String
    Friend TG904_EMAIL3_PDV As String
    Friend TG904_CODSEDEAMM_PDV As String
    Friend TG904_CODSEDELEG_PDV As String
    Friend TG904_COD_PDV As String
End Class

Public Class Tsp
    Public Sub New()

    End Sub
    Public Sub New(stringtsp As String)
        MessageBox.Show("TSP " & stringtsp)
        TG904_CODTRASP = stringtsp.Substring(3, 6)
        TG904_CODTRASP_TE1 = stringtsp.Substring(9, 1)
        TG904_CODTRASP_TE2 = stringtsp.Substring(10, 1)
        TG904_CODTRASP_TE3 = stringtsp.Substring(11, 1)
        TG904_CODTRASP_TE4 = stringtsp.Substring(12, 1)
        TG904_CODTRASP_TE5 = stringtsp.Substring(13, 1)
        TG904_CODTRASP_RS = stringtsp.Substring(14, 50)
        TG904_CODTRASP_RSE = stringtsp.Substring(64, 40)
        TG904_CODTRASP_IND = stringtsp.Substring(104, 50)
        TG904_CODTRASP_CAP = stringtsp.Substring(154, 5)
        TG904_CODTRASP_LOC = stringtsp.Substring(159, 50)
        TG904_CODTRASP_TEL = stringtsp.Substring(209, 15)
        TG904_ODTRASP_TLX = stringtsp.Substring(224, 10)
        TG904_CODTRASP_FAX = stringtsp.Substring(234, 10)
        TG904_CODTRASP_EMAIL1 = stringtsp.Substring(244, 50)
        TG904_CODTRASP_EMAIL2 = stringtsp.Substring(294, 50)
        TG904_CODTRASP_EMAIL3 = stringtsp.Substring(344, 50)
        TG904_CODTRASP_DTPC = stringtsp.Substring(394, 8)


    End Sub
    Friend TG904_ODTRASP_TLX As String
    Friend TG904_CODTRASP As String
    Friend TG904_CODTRASP_TE1 As String
    Friend TG904_CODTRASP_TE2 As String
    Friend TG904_CODTRASP_TE3 As String
    Friend TG904_CODTRASP_TE4 As String
    Friend TG904_CODTRASP_TE5 As String
    Friend TG904_CODTRASP_RS As String
    Friend TG904_CODTRASP_RSE As String
    Friend TG904_CODTRASP_IND As String
    Friend TG904_CODTRASP_CAP As String
    Friend TG904_CODTRASP_LOC As String
    Friend TG904_CODTRASP_TEL As String
    Friend TG904_CODTRASP_TLX As String
    Friend TG904_CODTRASP_FAX As String
    Friend TG904_CODTRASP_EMAIL1 As String
    Friend TG904_CODTRASP_EMAIL2 As String
    Friend TG904_CODTRASP_EMAIL3 As String
    Friend TG904_CODTRASP_DTPC As String
End Class
Public Class Mit

    Public Sub New()

    End Sub
    Public Sub New(stringmit As String)
        MessageBox.Show("MIT " & stringmit)
        TG904_SIGLA = stringmit.Substring(3, 2)
        TG904_DES_MAG = stringmit.Substring(5, 30)
        TG904_IND_MAG = stringmit.Substring(35, 30)
        TG904_LOC_MAG = stringmit.Substring(65, 20)
        TG904_CODFG070 = stringmit.Substring(85, 6)
        TG904_RAGSOC_CLI = stringmit.Substring(91, 50)
        TG904_RAGSOC_E_CLI = stringmit.Substring(141, 40)
        TG904_BANCA_CLI = stringmit.Substring(181, 35)
        TG904_TELEFONO_CLI = stringmit.Substring(216, 15)
        TG904_TELEX_CLI = stringmit.Substring(231, 10)
        TG904_FAX_CLI = stringmit.Substring(241, 10)
        TG904_IND_CLI = stringmit.Substring(251, 50)
        TG904_CAP_CLI = stringmit.Substring(301, 5)
        TG904_LOC_CLI = stringmit.Substring(306, 50)
        TG904_PROV_CLI = stringmit.Substring(356, 3)
        TG904_CODFISC_CLI = stringmit.Substring(359, 16)
        TG904_PARTIVA_CLI = stringmit.Substring(375, 11)
        TG904_TELEX_CLI1 = stringmit.Substring(386, 15)
        TG904_FAX_CLI1 = stringmit.Substring(401, 15)
        TG904_TEL_MAG = stringmit.Substring(416, 15)
        TG904_TELEX_MAG = stringmit.Substring(431, 15)
        TG904_FAX_MAG = stringmit.Substring(446, 15)

        MessageBox.Show("Telefono CLI " & TG904_TELEFONO_CLI)
    End Sub
    Friend TG904_SIGLA As String
    Friend TG904_LOC_CLI As String
    Friend TG904_DES_MAG As String
    Friend TG904_IND_MAG As String
    Friend TG904_LOC_MAG As String
    Friend TG904_CODFG070 As String
    Friend TG904_RAGSOC_CLI As String
    Friend TG904_RAGSOC_E_CLI As String
    Friend TG904_BANCA_CLI As String
    Friend TG904_TELEFONO_CLI As String
    Friend TG904_TELEX_CLI As String
    Friend TG904_FAX_CLI As String
    Friend TG904_IND_CLI As String
    Friend TG904_CAP_CLI As String
    Friend TG90_LOC_CLI As String
    Friend TG904_PROV_CLI As String
    Friend TG904_CODFISC_CLI As String
    Friend TG904_PARTIVA_CLI As String
    Friend TG904_TELEX_CLI1 As String
    Friend TG904_FAX_CLI1 As String
    Friend TG904_TEL_MAG As String
    Friend TG904_TELEX_MAG As String
    Friend TG904_FAX_MAG As String


End Class

'TO DO fare pull di Tg094.vb pc nuovo'
'Arrivato a pagina 288 tg904.txt'

Public Class Det
    Public Sub New()

    End Sub
    Public Sub New(stringdet As String)
        MessageBox.Show("DET " & stringdet)
        TG904_SCHEMA = stringdet.Substring(3, 4)
        TG904_NART_ORD_D = stringdet.Substring(7, 10)
        TG904_NART_ORD_OM_D = stringdet.Substring(17, 10)
        TG904_NART_CON_D = stringdet.Substring(27, 10)
        TG904_NART_CON_OM_D = stringdet.Substring(37, 10)
        TG904_CART_ORD_D = stringdet.Substring(47, 10)
        TG904_CART_ORD_OM_D = stringdet.Substring(57, 10)
        TG904_CART_CON_D = stringdet.Substring(67, 10)
        TG904_CART_CON_OM_D = stringdet.Substring(77, 10)
        TG904_PLT_ORD_D = stringdet.Substring(87, 8)
        TG904_PLT_CON_D = stringdet.Substring(95, 8)
        TG904_FORM_PLT_FORN = stringdet.Substring(103, 20)
        TG904_CART_STRATO_FOR = stringdet.Substring(103, 4)
        TG904_NUM_STRATO_FOR = stringdet.Substring(107, 4)
        TG904_QTA_FORN_FOR = stringdet.Substring(111, 4)
        TG904_QTA_TERMO_FOR = stringdet.Substring(115, 4)
        TG904_NOTE_ORD_D = stringdet.Substring(123, 80)
        TG904_PNT_CAR = stringdet.Substring(203, 8)
        TG904_STATO_RIG = stringdet.Substring(211, 1)

    End Sub
    Friend TG904_CART_ORD_D As String
    Friend TG904_QTA_FORN_FOR As String
    Friend TG904_PLT_ORD_D As String
    Friend TG904_SCHEMA As String
    Friend TG904_NART_ORD_D As String
    Friend TG904_NART_ORD_OM_D As String
    Friend TG904_NART_CON_D As String
    Friend TG904_NART_CON_OM_D As String
    Friend TG904_ART_ORD_D As String
    Friend TG904_CART_ORD_OM_D As String
    Friend TG904_CART_CON_D As String
    Friend TG904_CART_CON_OM_D As String
    Friend TG904_PLT_CON_D As String 'Arrivato a linea 235 file tg094.txt'
    Friend TG904_FORM_PLT_FORN As String
    Friend TG904_CART_STRATO_FOR As String
    Friend TG904_NUM_STRATO_FOR As String
    Friend TG904_QT_FOR_For As String
    Friend TG904_QTA_TERMO_FOR As String
    Friend TG904_NOTE_ORD_D As String
    Friend TG904_PNT_CAR As String
    Friend TG904_STATO_RIG As String

End Class
'Arrivato riga 248'
Public Class Pro
    Public Sub New()

    End Sub
    Public Sub New(proStr As String)
        MessageBox.Show("PRO " & proStr)
        TG904_CODPRO = proStr.Substring(3, 12)
        TG904_DES_PRO = proStr.Substring(15, 50)
        TG904_BCODE = proStr.Substring(65, 14)
        TG904_TIPO = proStr.Substring(79, 1)
        TG904_PUM = proStr.Substring(80, 8)
        TG904_PUM_UM = proStr.Substring(80, 2)
        TG904_PUM_QTA = proStr.Substring(82, 6)
        TG904_GR = proStr.Substring(88, 2)
        TG904_PESO_PRO = proStr.Substring(90, 6)
        TG904_DIM_PRO = proStr.Substring(96, 12)
        TG904_DIM_LATO1_PRO = proStr.Substring(96, 4)
        TG904_DIM_LATO2_PRO = proStr.Substring(100, 4)
        TG904_DIM_LATO3_PRO = proStr.Substring(104, 4)
        TG904_PNT_SC_CAR = proStr.Substring(108, 6)
        TG904_FORMA = proStr.Substring(114, 3)
        TG904_DURATA = proStr.Substring(117, 4)
        TG904_QTA_BCODE = proStr.Substring(121, 4)
        TG904_QTA_FORN = proStr.Substring(125, 6)
        TG904_QTA_TERMO = proStr.Substring(131, 6)
        TG904_FORM_PLT_MAG = proStr.Substring(137, 8)
        TG904_CART_STRATO_MAG = proStr.Substring(137, 4)
        TG904_NUM_STRATO_MAG = proStr.Substring(141, 4)
        TG904_QTA_VENDITA = proStr.Substring(145, 6)
        TG904_PESO_UVC = proStr.Substring(151, 6)
        TG904_DIM_UVC = proStr.Substring(157, 12)
        TG904_Dim_LATO1_UVC = proStr.Substring(157, 4)
        TG904_DIM_LATO2_UVC = proStr.Substring(161, 4)
        TG904_DIM_LATO3_UVC = proStr.Substring(165, 4)
        TG904_VARIETA = proStr.Substring(170, 10)
        TG904_NAZORI = proStr.Substring(180, 4)
        TG904_LOCAL = proStr.Substring(184, 5)
        TG904_CALIBRO = proStr.Substring(189, 7)
        TG904_CATEG = proStr.Substring(196, 2)
        TG904_TCONF = proStr.Substring(198, 4)
        TG904_TIMB = proStr.Substring(202, 3)
        TG904_FIMB = proStr.Substring(205, 1)
        TG904_UM = proStr.Substring(206, 2)
        TG904_CODIVA = proStr.Substring(208, 3)
        TG904_ALIQ = proStr.Substring(211, 4)
        TG904_CODF_TV = proStr.Substring(215, 200)


    End Sub
    Friend TG904_CODPRO As String
    Friend TG904_NUM_STRATO_MAG As String
    Friend TG904_DES_PRO As String
    Friend TG904_BCODE As String
    Friend TG904_TIPO As String
    Friend TG904_PUM As String
    Friend TG904_PUM_UM As String
    Friend TG904_PUM_QTA As String
    Friend TG904_GR As String
    Friend TG904_PESO_PRO As String
    Friend TG904_DIM_PRO As String
    Friend TG904_DIM_LATO1_PRO As String
    Friend TG904_DIM_LATO2_PRO As String
    Friend TG904_DIM_LATO3_PRO As String
    Friend TG904_PNT_SC_CAR As String
    Friend TG904_FORMA As String
    Friend TG904_DURATA As String
    Friend TG904_QTA_BCODE As String
    Friend TG904_QTA_FORN As String
    Friend TG904_QTA_TERMO As String
    Friend TG904_FORM_PLT_MAG As String
    Friend TG904_CART_STRATO_MAG As String
    Friend TG904_QTA_VENDITA As String
    Friend TG904_PESO_UVC As String
    Friend TG904_DIM_UVC As String
    Friend TG904_Dim_LATO1_UVC As String
    Friend TG904_DIM_LATO2_UVC As String
    Friend TG904_DIM_LATO3_UVC As String
    Friend TG904_VARIETA As String
    Friend TG904_NAZORI As String
    Friend TG904_LOCAL As String
    Friend TG904_CALIBRO As String
    Friend TG904_CATEG As String
    Friend TG904_TCONF As String
    Friend TG904_TIMB As String
    Friend TG904_FIMB As String
    Friend TG904_UM As String
    Friend TG904_CODIVA As String
    Friend TG904_ALIQ As String
    Friend TG904_CODF_TV As String
    Friend TG904_CODF_E As String
    Friend TG90_RG_LIST As String

    Friend TG904_CODF As String
    Friend TG904_PG_LIST As String
    Friend TG904_P_BUYER As String
    Friend TG904_P_DES_BUYER As String
    Friend TG904_BCODE_IMB As String
    Friend TG904_QTA_BCODE_IMB As String
    Friend TG904_DTSCAD1 As String
    Friend TG904_DTSCAD2 As String
    Friend TG904_ART62 As String
    Friend TG904_RE5 As String
    Friend TG904_LNF As String
    Friend TG904_BCODA As String
    Friend TG904_DTINS_BCODE As String
    Friend TG904_DTINS_BCODE_IMB As String
    Friend TG904_DTINS_BCODA As String
    Friend TG904_GR1 As String
    Friend TG904_GR2 As String
    Friend TG904_GR3 As String
    Friend TG904_GR4 As String
    Friend TG904_GR5 As String

End Class

Public Class Col
    Public Sub New()

    End Sub
    Public Sub New(colStr As String)
        MessageBox.Show("COL " & colStr)
    End Sub
    Friend TG904_COS As String
    Friend TG904_COSV As String
    Friend TG904_STRINGA As String
End Class
Public Class EndTr
    Public Sub New()

    End Sub
    Public Sub New(endStr)
        MessageBox.Show("ENDTR " & endStr)
    End Sub
    Friend TG904_NRK As String
End Class











