//*****************************************************************************
//*
//*
//*		TreeList.cpp
//*
//*
//*****************************************************************************
// TreeList.cpp : Legt das Klassenverhalten für die Anwendung fest.
//
#include	"StdAfx.h"
#include	"TreeList.h"
#include	"TreeListDlg.h"

#ifdef		_DEBUG
#define new	 DEBUG_NEW
#undef		 THIS_FILE
static char	 THIS_FILE[] = __FILE__;
#endif


BEGIN_MESSAGE_MAP(CTreeListApp, CWinApp)
	//{{AFX_MSG_MAP(CTreeListApp)
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

CTreeListApp theApp;

//*****************************************************************************
//*
//*		CTreeListApp
//*
//*****************************************************************************
//  CTreeListApp Konstruktion
CTreeListApp::CTreeListApp()
{
}


//*****************************************************************************
//*
//*		InitInstance
//*
//*****************************************************************************
//  CTreeListApp Initialisierung
BOOL CTreeListApp::InitInstance()
{
	AfxEnableControlContainer();


	#ifdef		_AFXDLL 				
	Enable3dControls(); 		
	#else
	Enable3dControlsStatic();	
	#endif

	CTreeListDlg dlg;
	m_pMainWnd = &dlg;
	int nResponse = dlg.DoModal();
	if(nResponse == IDOK)
		{
		}
	else if(nResponse == IDCANCEL)
		{
		}


return FALSE;
}
