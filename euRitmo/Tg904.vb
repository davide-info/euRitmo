Public Class Tg904
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
    Private TG904_OP As String
    Private TG904_TMOPE As String
    Private TG904_DTPC As String
    Private TG904_CMPT As String
    Private TG904_STATO_ORD As String()
    Private TG904_COD_BUYER As String()
    Private TG904_DES_BUYER As String()
    Private TG904_NART_ORD_T As String()
    Private TG904_NART_CON_T As String()
    Private TG904_CART_ORD_OMT_T As String()
    Private TG904_CART_CON_T As String()
    Private TG904_CART_CON_OM_T As String()
    Private TG904_PLT_ORD_T As String()
    Private TG904_PLT_CON_T As String()
    Private TG904_VAL_ORD_T As String()
    Private TG904_NOTE_ORD_T As String()
    Private TG904_SC_ORD_T As String()
    Private TG90_DTCON As String()
    Private TG904_DTDOC As String()


    Sub New()

    End Sub

    Sub New(ByVal stringTes As String)
        TG904_TRK = stringTes.Substring(0, 3)
        TG904_OP = stringTes.Substring(3, 1)
        TG904_TMOPE = stringTes.Substring(12, 8)



    End Sub











End Class
Class Forn
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