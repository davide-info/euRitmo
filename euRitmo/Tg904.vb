﻿Public Class Tg904
    Private Tes As Tes


    Friend Sub setTes(Tes As Tes)
        Me.Tes = Tes
    End Sub




End Class

Public Class Dtope
    Private DTOPE_SAA As String()
    Private DTOPE_MM As String()
    Private DTOPE_GG As String()
    Public Sub setDtopeMM(DTOPE_MM() As String)
        Me.DTOPE_MM = DTOPE_MM



    End Sub
    Public Function getDtopeMM() As String()
        Return Me.DTOPE_MM


    End Function

    Public Sub setDtopseSaa(DTOPE_SAA As String())
        Me.DTOPE_SAA = DTOPE_SAA


    End Sub
    Public Function GetDtopeSaa() As String()
        Return Me.DTOPE_SAA

    End Function


End Class
Public Class Tes
    Private TG904_TRK As String
    Public Sub setTG904_TRK(TG904_TRK As String)
        Me.TG_904_TRK = TG904_TRK


    End Sub
    Public Function getTG904_TRK()
        Return TG904_TRK
    End Function

    Private TG904_OP As String
    Public Sub setTG904_OP(TG904_OP As String)
        Me.TG904_OP = TG904_OP

    End Sub
    Public Function getTG904_OP() As String
        Return TG904_OP
    End Function

    Private TG904_TMOPE As String
    Public Sub setTG904_TMOPE(TG904_TMOPE As String)
        Me.TG904_TMOPE = TG904_TMOPE
    End Sub
    Public Function getTG904_TMOPE() As String
        Return Me.TG904_TMOPE
    End Function
    Private TG904_DTPC As String
    Public Sub setTG904_DTCP(TG94_DTCP As String)
        Me.TG904_DTCP = TG904_DTPC
    End Sub
    Public Function getTG904_DTCP() As String
        Return TG904_DTCP
    End Function

    Private TG904_CMPT As String
    Public Sub setTG904_CMPT(TG904_CMPT As String)
        Me.TG904_CMPT = TG904_CMPT

    End Sub
    Public Function getTG904_CMPT() As String
        Return TG904_CMPT
    End Function
    Private TG904_STATO_ORD As String()
    Public Sub setTG904_STATO_ORD(TG904_STATO_ORD As String())
        Me.TG904_STATO_ORD = TG904_STATO_ORD


    End Sub
    Public Function getTG904_STATO_ORD() As String()
        Return TG904_STATO_ORD

    End Function

    Private TG904_COD_BUYER As String()
    Public Sub setTG904_COD_BUYER(TG904_COD_BUYER As String())
        Me.TG904_COD_BUYER = TG904_COD_BUYER


    End Sub
    Public Function getTG904_COD_BUYER() As String()
        Return TG904_COD_BUYER

    End Function


    Private TG904_DES_BUYER As String()
    Public Sub setTG904_DES_BUYER(TG904_DES_BUYER As String())
        Me.TG904_DES_BUYER = TG904_DES_BUYER

    End Sub
    Public Function getTG904_DES_BUYER() As String()
        Return Me.TG904_DES_BUYER


    End Function

    Private TG904_NART_ORD_T As String()
    Public Sub setTG904_NART_ORD_T(TG904_NART_ORD_T As String())
        Me.TG904_NART_ORD_T = TG904_NART_ORD_T


    End Sub


    Private TG904_NART_CON_T As String()
    Public Sub setTG904_NART_CON_T(TG904_NART_CON_T As String())
        Me.TG904_NART_CON_T = TG904_NART_CON_T


    End Sub

    Private TG904_CART_ORD_OMT_T As String()
    Public Sub setTG904_CART_ORD_OMT_T(TG904_CART_ORD_OMT_T As String())
        Me.TG904_CART_ORD_OMT_T = TG904_CART_ORD_OMT_T


    End Sub
    Public Function getTG904_CART_ORD_OMT_T() As String()
        Return Me.TG904_CART_ORD_OMT_T

    End Function
    Private TG904_CART_CON_T As String()
    Public Sub setTG904_CART_CON_T(TG904_CART_CON_T As String())
        Me.TG904_CART_CON_T = TG904_CART_CON_T


    End Sub

    Public Function getTG904_CART_CON_T() As String()
        Return TG904_CART_CON_T

    End Function

    Private TG904_CART_CON_OM_T As String()
    Public Sub setTG904_CART_CON_OM_T(TG904_CART_CON_OM_T As String())
        Me.TG904_CART_CON_OM_T = TG904_CART_CON_OM_T



    End Sub
    Public Function getTG904_CART_CON_OM_T() As String()
        Return TG904_CART_CON_OM_T

    End Function

    Private TG904_PLT_ORD_T As String()
    Public Sub setTG904_PLT_ORD_T(TG904_PLT_ORD_T As String())
        Me.TG904_PLT_ORD_T = TG904_PLT_ORD_T


    End Sub
    Public Function getTG904_PLT_ORD_T() As String()
        Return TG904_PLT_ORD_T

    End Function


    Private TG904_PLT_CON_T As String()
    Public Sub setTG904_PLT_CON_T(TG904_PLT_CON_T As String())
        Me.TG904_PLT_CON_T = TG904_PLT_CON_T


    End Sub
    Public Function getTG904_PLT_CON_T() As String()
        Return TG904_PLT_CON_T

    End Function

    Private TG904_VAL_ORD_T As String()
    Private Sub setTG904_VAL_ORD_T(TG904_VAL_ORD_T As String())
        Me.TG904_VAL_ORD_T = TG904_VAL_ORD_T


    End Sub
    Public Function getTG904_VAL_ORD_T() As String()
        Return TG904_VAL_ORD_T
    End Function

    Private TG904_NOTE_ORD_T As String()
    Public Sub setTG904_NOTE_ORD_T(TG904_NOTE_TG904_VAL_ORD_T As String())
        Me.TG904_NOTE_ORD_T = TG904_NOTE_ORD_T


    End Sub
    Public Function GetTG904_NOTE_ORD_T() As String()
        Return TG904_NOTE_ORD_T
    End Function

    Private TG904_SC_ORD_T As String()
    Public Sub setTG904_SC_ORD_T(TG904_SC_ORD_T As String())
        Me.TG904_SC_ORD_T = TG904_SC_ORD_T


    End Sub
    Public Function getTG904_SC_ORD_T() As String()
        Return TG904_SC_ORD_T
    End Function
    Private TG904_DTCON As String()
    Public Sub setTG90_DTCON(TG904_DTCON As String())
        Me.TG904_DTCON = TG904_DTCON
    End Sub
    Public Function getTG90_DTCON() As String()
        Return TG904_DTCON
    End Function

    Private TG904_DTDOC As String()
    Public Sub setTG904_DTDOC(TG904_DTDOC As String())
        Me.TG904_DTDOC = TG904_DTDOC


    End Sub
    Public Function getTG904_DTDOC() As String()
        Return TG904_DTDOC
    End Function

    Sub New()

    End Sub

    Sub New(ByVal stringTes As String)
        TG904_TRK = stringTes.Substring(0, 3)
        TG904_OP = stringTes.Substring(3, 1)
        TG904_TMOPE = stringTes.Substring(12, 8)



    End Sub











End Class
Public Class Forn
    Private TG904_RAGSOC_For As String()
    Private TG904_RAGSOC_E_FOR As String()
    Private TG904_BANCA_FOR As String()
    Private TG904_TELEFONO_FOR As String()
    Private TG904_TELEX_FOR As String()
    Private TG904_FAX_FOR As String()
    Private TG904_RAPP As String()
    Private TG904_CAPO_AREA As String()
    Private TG904_CAPO_AREA_TEL As String()
    Private TG904_DIR_COMM As String()
    Private TG904_DIR_COMM_TEL As String()
    Private TG904_COD_PAG1 As String()
    Private TG904_COD_PAG2 As String()
    Private TG904_COD_PAG3 As String()
    Private TG904_NOTE1_FOR As String()
    Private TG904_NOTE2_For As String()
    Private TG904_IND_FOR As String()
    Private TG904_CAP_FOR As String()
    Private TG904_LOC_FOR As String()
    Private TG904_PROV_FOR As String()
    Private TG904_CODFISC_For As String()
    Private TG904_PARTIVA_FOR As String()
    Private TG904_ORA_PREF As String()
    Private TG904_HH_PREF As String()
    Private TG904_MM_PREF As String()
    Private TG904_EMAIL1 As String()
    Private TG904_EMAIL2 As String()
    Private TG904_EMAIL3 As String()
    Private TG904_WEB As String()
    Private TG904_TELEX_FOR1 As String()
    Private TG904_FAX_FOR1 As String()
    Private TG904_COD_PAG As String()
    Private TG904_COD_PAG_DES As String()
    Private TG904_FG050_FLAG1 As String()
    Private TG904_FG050_FLAG2 As String()
    Private TG904_FG050_FLAG3 As String()
    Private TG904_FG050_FLAG4 As String()
    Private TG904_FG050_FLAG5 As String()
    Private TG904_CODFORR As String()
End Class
Public Class Rub
    Private TG904_RUB_SERVIZIO As String()
    Private TG904_RUB_IND As String()
End Class
Public Class Pdv
    Private TG904_RAGSOC_PDV As String()
    Private TG904_RAGSOC_E_PDV As String()
    Private TG904_TELEFONO_PDV As String()
    Private TG904_TELEX_PDV As String()
    Private TG904_FAX_PDV As String()
    Private TG904_IND_PDV As String()
    Private TG904_CAP_PDV As String()
    Private TG904_LOC_PDV As String()
    Private TG904_PROV_PDV As String()
    Private TG904_IND_BC_PDV As String()
    Private TG904_CAP_BC_PDV As String()
    Private TG904_LOC_BC_PDV As String()
    Private TG904_PROV_BC_PDV As String()
    Private TG904_CODFISC_PDV As String()
    Private TG904_PARTIVA_PDV As String()
    Private TG904_EMAIL1_PDV As String()
    Private TG904_EMAIL2_PDV As String()
    Private TG904_EMAIL3_PDV As String()
    Private TG904_CODSEDEAMM_PDV As String()
    Private TG904_CODSEDELEG_PDV As String()
    Private TG904_COD_PDV as String()
End Class

Public Class Tsp
    Private TG904_CODTRASP As String()
    Private TG904_CODTRASP_TE1 As String()
    Private TG904_CODTRASP_TE2 As String()
    Private TG904_CODTRASP_TE3 As String()
    Private TG904_CODTRASP_TE4 As String()
    Private TG904_CODTRASP_TE5 As String()
    Private TG904_CODTRASP_RS As String()
    Private TG904_CODTRASP_RSE As String()
    Private TG904_CODTRASP_IND As String()
    Private TG904_CODTRASP_CAP As String()
    Private TG904_CODTRASP_LOC As String()
    Private TG904_CODTRASP_TEL As String()
    Private TG904_CODTRASP_TLX As String()
    Private TG904_CODTRASP_FAX As String()
    Private TG904_CODTRASP_EMAIL1 As String()
    Private TG904_CODTRASP_EMAIL2 As String()
    Private TG904_CODTRASP_EMAIL3 As String()
    Private TG904_CODTRASP_DTPC As String()
End Class
Public Class Mit
    Private TG904_SIGLA As String()
    Private TG904_DES_MAG As String()
    Private TG904_IND_MAG As String()
    Private TG904_LOC_MAG As String()
    Private TG904_CODFG070 As String()
    Private TG904_RAGSOC_CLI As String()
    Private TG904_RAGSOC_E_CLI As String()
    Private TG904_BANCA_CLI As String()
    Private TG904_TELEFONO_CLI As String()
    Private TG904_TELEX_CLI As String()
    Private TG904_FAX_CLI As String()
    Private TG904_IND_CLI As String()
    Private TG904_CAP_CLI As String()
    Private TG90_LOC_CLI As String()
    Private TG904_PROV_CLI As String()
    Private TG904_CODFISC_CLI As String()
    Private TG904_PARTIVA_CLI As String()
    Private TG904_TELEX_CLI1 As String()
    Private TG904_FAX_CLI1 As String()
    Private TG904_TEL_MAG As String()
    Private TG904_TELEX_MAG As String()
    Private TG904_FAX_MAG As String()


End Class

'TO DO fare pull di Tg094.vb'

Public Class Det
    Private TG904_SCHEMA As String()
    Private TG904_NART_ORD_D As String()
    Private TG904_NART_ORD_OM_D As String()
    Private TG904_NART_CON_D As String()
    Private TG904_NART_CON_OM_D As String()
    Private TG904_ART_ORD_D As String()
    Private TG904_CART_ORD_OM_D As String()
    Private TG904_CART_CON_D As String()
    Private TG904_CART_CON_OM_D As String()
    Private TG904_PLT_CON_D As String() 'Arrivato a linea 235 file tg094.txt'
    Private TG904_FORM_PLT_FORN       as String()
    Private  TG904_CART_STRATO_FOR     as string()
    Private TG904_NUM_STRATO_FOR As String()
    Private TG904_QT_FOR_For As String()
    Private TG904_QTA_TERMO_FOR  as String()
    Private TG904_NOTE_ORD_D      as string()
    Private TG904_PNT_CAR      as String()
    private TG904_STATO_RIG   as String()    

End Class
'Arrivato riga 248'
Public Class Pro


End Class












