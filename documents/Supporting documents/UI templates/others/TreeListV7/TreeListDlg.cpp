//*****************************************************************************
//*
//*
//*		TreeListDlg.cpp
//*
//*
//*****************************************************************************
#include	"StdAfx.h"
#include	"TreeList.h"
#include	"TreeListDlg.h"

#ifdef		_DEBUG
#define new	 DEBUG_NEW
#undef		 THIS_FILE
static char	 THIS_FILE[] = __FILE__;
#endif


char	   *pItems1[]	    = {"Europe" ,"Asia"  ,"America"};
char	   *pItems2[]		= {"Austria","Germany","China","Japan","Canada","Mexico"};
char	   *pItems3[]		= {"Vienna" ,"Graz"   ,"Berlin","Munich","Beijing","Shanghai","Tokyo","Osaka","Ottawa","Toronto","Mexico City","Monerrey"};

#define 	ENTRIES(a)	(sizeof(a)/sizeof(a[0]))
#define 	IDC_TREELIST	123
#define 	USER_DATA_SIZE	256

COLORREF	aColors[]= 	{
							TV_NOCOLOR,
							RGB(0,0,0),
							RGB(255,0,0),
							RGB(0,255,0),
							RGB(0,0,255),
							RGB(255,255,0),
							RGB(255,0,255),
							RGB(0,255,255),
							RGB(128,128,128),
							RGB(255,128,128),
							RGB(128,255,128),
							RGB(128,128,255),
							RGB(255,255,128),
							RGB(255,128,255),
							RGB(128,255,255),
							RGB(192,192,192),
							RGB(255,192,192),
							RGB(192,255,192),
							RGB(192,192,255),
							RGB(255,255,192),
							RGB(255,192,255),
							RGB(192,255,255),
							RGB(255,255,255),
							};


int			iComboIds[] =	{
							IDC_COMBO1,
							IDC_COMBO2,
							IDC_COMBO3,
							IDC_COMBO4,
							IDC_COMBO5,
							IDC_COMBO6,
							IDC_COMBO7,
							IDC_COMBO8,
							};

int			iIdList[] =		{
							IDC_CHECK1	,TVS_HASBUTTONS         ,0,
							IDC_CHECK2	,TVS_HASLINES           ,0,
							IDC_CHECK3	,TVS_LINESATROOT        ,0,
							IDC_CHECK4	,TVS_SHOWSELALWAYS      ,0,
							IDC_CHECK5	,TVS_NOTOOLTIPS         ,0,
							IDC_CHECK6	,TVS_CHECKBOXES         ,0,
							IDC_CHECK7	,TVS_TRACKSELECT        ,0,
							IDC_CHECK8	,TVS_SINGLEEXPAND       ,0,
							IDC_CHECK9 	,TVS_FULLROWSELECT      ,0,
							IDC_CHECK10	,TVS_NOSCROLL           ,0,
							IDC_CHECK11	,TVS_NONEVENHEIGHT      ,0,
							IDC_CHECK18	,TVS_EDITLABELS         ,0,
							IDC_CHECK12	,TVS_EX_ITEMLINES		,1,
							IDC_CHECK13	,TVS_EX_ALTERNATECOLOR	,1,
							IDC_CHECK14	,TVS_EX_SUBSELECT		,1,
							IDC_CHECK15	,TVS_EX_FULLROWMARK		,1,
							IDC_CHECK16	,TVS_EX_MULTISELECT		,1,
							IDC_CHECK17	,TVS_EX_AUTOHSCROLL 	,1,
							};


BEGIN_MESSAGE_MAP(CTreeListDlg, CDialog)
	//{{AFX_MSG_MAP(CTreeListDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_CHECK1,  OnCheck1)
	ON_BN_CLICKED(IDC_CHECK2,  OnCheck2)
	ON_BN_CLICKED(IDC_CHECK3,  OnCheck3)
	ON_BN_CLICKED(IDC_CHECK4,  OnCheck4)
	ON_BN_CLICKED(IDC_CHECK5,  OnCheck5)
	ON_BN_CLICKED(IDC_CHECK6,  OnCheck6)
	ON_BN_CLICKED(IDC_CHECK7,  OnCheck7)
	ON_BN_CLICKED(IDC_CHECK8,  OnCheck8)
	ON_BN_CLICKED(IDC_CHECK9,  OnCheck9)
	ON_BN_CLICKED(IDC_CHECK10, OnCheck10)
	ON_BN_CLICKED(IDC_CHECK11, OnCheck11)
	ON_BN_CLICKED(IDC_CHECK12, OnCheck12)
	ON_BN_CLICKED(IDC_CHECK13, OnCheck13)
	ON_BN_CLICKED(IDC_CHECK14, OnCheck14)
	ON_BN_CLICKED(IDC_CHECK15, OnCheck15)
	ON_BN_CLICKED(IDC_CHECK16, OnCheck16)
	ON_BN_CLICKED(IDC_CHECK17, OnCheck17)
	ON_BN_CLICKED(IDC_CHECK18, OnCheck18)
	ON_BN_CLICKED(IDC_CHECK19, OnCheck19)
	ON_BN_CLICKED(IDC_CHECK20, OnCheck20)
	ON_BN_CLICKED(IDC_CHECK21, OnCheck21)
	ON_WM_DRAWITEM()
	ON_CBN_SELCHANGE(IDC_COMBO1, OnChangeColor1)
	ON_CBN_SELCHANGE(IDC_COMBO2, OnChangeColor2)
	ON_CBN_SELCHANGE(IDC_COMBO3, OnChangeColor3)
	ON_CBN_SELCHANGE(IDC_COMBO4, OnChangeColor4)
	ON_CBN_SELCHANGE(IDC_COMBO5, OnChangeColor5)
	ON_CBN_SELCHANGE(IDC_COMBO6, OnChangeColor6)
	ON_CBN_SELCHANGE(IDC_COMBO7, OnChangeColor7)
	ON_CBN_SELCHANGE(IDC_COMBO8, OnChangeColor8)
	ON_BN_CLICKED(IDC_EDIT, OnEdit)
	ON_BN_CLICKED(IDC_COMBO, OnCombo)
	//}}AFX_MSG_MAP
	ON_NOTIFY(NM_RETURN,		 IDC_TREELIST, OnReturn)
	ON_NOTIFY(TVN_SELCHANGED,    IDC_TREELIST, OnSelChanged)
	ON_NOTIFY(TVN_COMUMNCLICK,   IDC_TREELIST, OnColumnClick)
	ON_NOTIFY(TVN_ITEMEXPANDED,  IDC_TREELIST, OnItemExpanded)
	ON_NOTIFY(TVN_ENDLABELEDIT,  IDC_TREELIST, OnEndLabelEdit)
	ON_NOTIFY(TVN_BEGINLABELEDIT,IDC_TREELIST, OnBeginLabelEdit)

END_MESSAGE_MAP()


//*****************************************************************************
//*
//*		CDialog
//*
//*****************************************************************************
CTreeListDlg::CTreeListDlg(CWnd* pParent/*=NULL*/): CDialog(CTreeListDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTreeListDlg)
	//}}AFX_DATA_INIT
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

//*****************************************************************************
//*
//*		DoDataExchange
//*
//*****************************************************************************
void CTreeListDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTreeListDlg)
	//}}AFX_DATA_MAP
}

//*****************************************************************************
//*
//*		OnInitDialog
//*
//*****************************************************************************
BOOL CTreeListDlg::OnInitDialog()
{
CRect		sRect;
CPoint		sPoint(0,0);
HTREEITEM	hItem1[3];
HTREEITEM	hItem2[3*2];
HTREEITEM	hItem3[3*2*2];
unsigned	uStyle;
unsigned	uExStyle;
int			i,j;



	GetDlgItem(IDC_FRAME)->GetWindowRect(&sRect);
	ClientToScreen(&sPoint);

	sRect.left	 -= sPoint.x;
	sRect.right	 -= sPoint.x;
	sRect.top	 -= sPoint.y;
	sRect.bottom -= sPoint.y;

	uStyle		= TVS_HASBUTTONS|TVS_HASBUTTONS|TVS_HASLINES|TVS_LINESATROOT|TVS_FULLROWSELECT;
	uExStyle	= TVS_EX_ITEMLINES|TVS_EX_ITEMLINES|TVS_EX_ALTERNATECOLOR|TVS_EX_SUBSELECT;
	m_hSelect	= NULL;
	m_iSelCol	= 0;
	
	m_cImages  .Create(IDB_FALGS,16,8,RGB(0,255,255));
	m_cTreeList.Create(uStyle|WS_CHILD|WS_VISIBLE|WS_BORDER,sRect,this,IDC_TREELIST);

	m_cTreeList.SetImageList(&m_cImages,TVSIL_NORMAL);
	m_cTreeList.InsertColumn(0,"Tree");
	m_cTreeList.InsertColumn(1,"Column 1");
	m_cTreeList.InsertColumn(2,"Column 2");
	m_cTreeList.SetExtendedStyle(uExStyle);
	m_cTreeList.SetUserDataSize(USER_DATA_SIZE);


	for(i=0;i<ENTRIES(iComboIds);i++)
		{
		for(j=0;j<ENTRIES(aColors);j++)
			{
			((CComboBox*)GetDlgItem(iComboIds[i]))->InsertString(j,"");
			}
		((CComboBox*)GetDlgItem(iComboIds[i]))->SetCurSel(0);
		}

	for(i=0;i<3;i++)
		{
		hItem1[i]=m_cTreeList.InsertItem(pItems1[i],i,i,TVI_ROOT);
		m_cTreeList.Expand(hItem1[i],TVE_EXPAND);
		}

	for(i=0;i<3*2;i++)
		{
		hItem2[i]=m_cTreeList.InsertItem(pItems2[i],i+3,i+3,hItem1[i/2]);
		if(i==0)m_cTreeList.Expand(hItem2[i],TVE_EXPAND);
		m_cTreeList.SetItem(hItem2[i],1+(i&1),TVIF_IMAGE|TVIF_TEXT,"Text",i+3,i+3,0,0,0);
		}

	for(i=0;i<3*2*2;i++)
		{
		hItem3[i]=m_cTreeList.InsertItem(pItems3[i],TV_NOIMAGE,TV_NOIMAGE,hItem2[i/2]);
		m_cTreeList.SetItem(hItem3[i],1+(i&1),TVIF_TEXT,"Text",0,0,0,0,0);
		}


	for(i=0;i<ENTRIES(iIdList);i+=3)
		{
		if(iIdList[i+2]==0)
			{
			if(uStyle&iIdList[i+1])GetDlgItem(iIdList[i])->SendMessage(BM_SETCHECK,BST_CHECKED);
			}

		if(iIdList[i+2]==1)
			{
			if(uExStyle&iIdList[i+1])GetDlgItem(iIdList[i])->SendMessage(BM_SETCHECK,BST_CHECKED);
			}
		}


	CDialog::OnInitDialog();

	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT( IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if(pSysMenu != NULL)
		{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if(!strAboutMenu.IsEmpty())
			{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
			}
		}

	SetIcon(m_hIcon, TRUE); 	
	SetIcon(m_hIcon, FALSE);	


return TRUE;  
}

//*****************************************************************************
//*
//*		OnSysCommand
//*
//*****************************************************************************
void CTreeListDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if((nID & 0xFFF0) == IDM_ABOUTBOX)
		{
		CDialog dlgAbout(IDD_ABOUTBOX);
		dlgAbout.DoModal();
		}
	else{
		if(nID==0xF060)OnCancel();
		CDialog::OnSysCommand(nID, lParam);
		}
}

//*****************************************************************************
//*
//*		OnPaint
//*
//*****************************************************************************
void CTreeListDlg::OnPaint()
{
	if(IsIconic())
		{
		CPaintDC dc(this);						

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		
		GetClientRect(&rect);
		
		int x = (rect.Width () - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		dc.DrawIcon(x, y, m_hIcon);
		}
	else{
		CDialog::OnPaint();
		}
}

//*****************************************************************************
//*
//*		OnQueryDragIcon
//*
//*****************************************************************************
HCURSOR CTreeListDlg::OnQueryDragIcon()
{

return (HCURSOR) m_hIcon;
}


//*****************************************************************************
//*
//*		OnDrawItem
//*
//*****************************************************************************
void CTreeListDlg::OnDrawItem(int nIDCtl, LPDRAWITEMSTRUCT pDrawItemStruct) 
{


	if(pDrawItemStruct->itemID<=0)
		{
		SetBkColor(pDrawItemStruct->hDC,RGB(255,255,255));
		ExtTextOut(pDrawItemStruct->hDC,3,2,ETO_OPAQUE,&pDrawItemStruct->rcItem,"default",7,NULL);
		}
	else{
		SetBkColor(pDrawItemStruct->hDC,aColors[pDrawItemStruct->itemID]);
		ExtTextOut(pDrawItemStruct->hDC,0,0,ETO_OPAQUE,&pDrawItemStruct->rcItem,NULL,0,NULL);
		}

}


//*****************************************************************************
//*
//*		OnCheck
//*
//*****************************************************************************
void CTreeListDlg::OnCheck1 (){OnCheck(IDC_CHECK1 );}
void CTreeListDlg::OnCheck2 (){OnCheck(IDC_CHECK2 );}
void CTreeListDlg::OnCheck3 (){OnCheck(IDC_CHECK3 );}
void CTreeListDlg::OnCheck4 (){OnCheck(IDC_CHECK4 );}
void CTreeListDlg::OnCheck5 (){OnCheck(IDC_CHECK5 );}
void CTreeListDlg::OnCheck6 (){OnCheck(IDC_CHECK6 );}
void CTreeListDlg::OnCheck7 (){OnCheck(IDC_CHECK7 );}
void CTreeListDlg::OnCheck8 (){OnCheck(IDC_CHECK8 );}
void CTreeListDlg::OnCheck9 (){OnCheck(IDC_CHECK9 );}
void CTreeListDlg::OnCheck10(){OnCheck(IDC_CHECK10);}
void CTreeListDlg::OnCheck11(){OnCheck(IDC_CHECK11);}
void CTreeListDlg::OnCheck12(){OnCheck(IDC_CHECK12);}
void CTreeListDlg::OnCheck13(){OnCheck(IDC_CHECK13);}
void CTreeListDlg::OnCheck14(){OnCheck(IDC_CHECK14);}
void CTreeListDlg::OnCheck15(){OnCheck(IDC_CHECK15);}
void CTreeListDlg::OnCheck16(){OnCheck(IDC_CHECK16);}
void CTreeListDlg::OnCheck17(){OnCheck(IDC_CHECK17);}
void CTreeListDlg::OnCheck18(){OnCheck(IDC_CHECK18);}
void CTreeListDlg::OnCheck(int iID) 
{
int			i,iOn;
unsigned 	uStyle;



	for(i=0;i<ENTRIES(iIdList);i+=3)
		{
		if(iIdList[i]!=iID)continue;

		iOn	= (GetDlgItem(iID)->SendMessage(BM_GETCHECK)==BST_CHECKED)? 1:0;


		if(iIdList[i+2]==0)
			{
			uStyle = GetWindowLong(m_cTreeList.m_hWnd,GWL_STYLE);
			
			if(iOn)uStyle|= iIdList[i+1];
			else   uStyle&=~iIdList[i+1];	

			SetWindowLong(m_cTreeList.m_hWnd,GWL_STYLE,uStyle);
			GetDlgItem(IDC_EDIT )->EnableWindow((uStyle&TVS_EDITLABELS)? TRUE:FALSE);
			GetDlgItem(IDC_COMBO)->EnableWindow((uStyle&TVS_EDITLABELS)? TRUE:FALSE);
			}

		if(iIdList[i+2]==1)
			{
			m_cTreeList.SetExtendedStyle(iIdList[i+1]*iOn,iIdList[i+1]);
			}
		}
	
	
}

void CTreeListDlg::OnCheck19()
{
	if(((CButton*)GetDlgItem(IDC_CHECK19))->GetCheck())
			m_uSelState |=  TVIS_BOLD;
	else	m_uSelState &= ~TVIS_BOLD;

	m_cTreeList.SetItemState(m_hSelect,m_iSelCol,m_uSelState,TVIS_BOLD);
}

void CTreeListDlg::OnCheck20()
{
	if(((CButton*)GetDlgItem(IDC_CHECK20))->GetCheck())
			m_uSelState |=  TVIS_UNTERLINE;
	else	m_uSelState &= ~TVIS_UNTERLINE;

	m_cTreeList.SetItemState(m_hSelect,m_iSelCol,m_uSelState,TVIS_UNTERLINE);
}

void CTreeListDlg::OnCheck21()
{
	if(((CButton*)GetDlgItem(IDC_CHECK21))->GetCheck())
			m_uSelState |=  TVIS_EXPANDED;
	else	m_uSelState &= ~TVIS_EXPANDED;

	m_cTreeList.SetItemState(m_hSelect,m_iSelCol,m_uSelState,TVIS_EXPANDED);
}

//*****************************************************************************
//*
//*		OnEdit
//*
//*****************************************************************************
void CTreeListDlg::OnEdit() 
{
	
	if(!m_hSelect)return;

	m_cTreeList.EditLabel(m_hSelect,m_iSelCol,0);
	
}

//*****************************************************************************
//*
//*		OnCombo
//*
//*****************************************************************************
void CTreeListDlg::OnCombo() 
{
CComboBox	*pCombo;

	
	if(!m_hSelect)return;

	pCombo = m_cTreeList.EditLabelCb(m_hSelect,m_iSelCol,1);
	pCombo->AddString("Hallo");
	pCombo->AddString("Wauuu..");
	pCombo->AddString("Yes");
	pCombo->AddString("No");


}

//*****************************************************************************
//*
//*		OnSelChanged
//*
//*****************************************************************************
void CTreeListDlg::OnSelChanged(NMHDR *pNmHdr,LRESULT *pResult)
{
NM_TREEVIEW *pNmTreeView = (NM_TREEVIEW*)pNmHdr;
TV_ITEM		 sItem;
char		 cUserData[256];
char		 cText[256]="";	
COLORREF	 uColor;	
CString		 sCol;
int			 i;




	if(pNmTreeView->itemOld.hItem)						// Update User-Data
		{
		i=GetDlgItemText(IDC_EDIT4,cUserData,sizeof(cUserData))+1;
		if(i>USER_DATA_SIZE)i=USER_DATA_SIZE;
		cUserData[sizeof(cUserData)-1]=0;
		memcpy(m_cTreeList.GetUserData(m_hSelect),cUserData,i);	
		}


	if(!pNmTreeView->itemNew.hItem)
		{
		GetDlgItem(IDC_CHECK19)->EnableWindow(FALSE);
		GetDlgItem(IDC_CHECK20)->EnableWindow(FALSE);
		GetDlgItem(IDC_CHECK21)->EnableWindow(FALSE);
		GetDlgItem(IDC_COMBO7 )->EnableWindow(FALSE);
		GetDlgItem(IDC_COMBO8 )->EnableWindow(FALSE);
		GetDlgItem(IDC_EDIT4  )->EnableWindow(FALSE);

		m_hSelect	 = NULL;
		m_iSelCol	 = 0;
		m_uSelState	 = 0;
		m_uSelState	 = 0;
		cUserData[0] = 0;   
		sCol		 = "";

		((CComboBox*)GetDlgItem(IDC_COMBO7))->SetCurSel(0);
		((CComboBox*)GetDlgItem(IDC_COMBO8))->SetCurSel(0);
		}
	else{
		GetDlgItem(IDC_CHECK19)->EnableWindow(TRUE);
		GetDlgItem(IDC_CHECK20)->EnableWindow(TRUE);
		GetDlgItem(IDC_CHECK21)->EnableWindow(TRUE);
		GetDlgItem(IDC_COMBO7 )->EnableWindow(TRUE);
		GetDlgItem(IDC_COMBO8 )->EnableWindow(TRUE);
		GetDlgItem(IDC_EDIT4  )->EnableWindow(TRUE);

		m_hSelect	= pNmTreeView->itemNew.hItem;
		m_iSelCol	= pNmTreeView->itemNew.cChildren;
		m_uSelState	= pNmTreeView->itemNew.state;
		
		sCol.Format("%i",m_iSelCol);

		sItem.mask		 = TVIF_TEXT|TVIF_HANDLE|TVIF_SUBITEM;
		sItem.pszText	 = cText;
		sItem.cchTextMax = sizeof(cText);
		sItem.hItem		 = m_hSelect;
		sItem.cChildren	 = m_iSelCol;
		
		m_cTreeList.GetItem(&sItem);


		uColor = m_cTreeList.GetItemBkColor(m_hSelect,m_iSelCol);

		for(i=ENTRIES(aColors)-1;i>0;i--)
			{
			if(uColor==aColors[i])break;
			}

		((CComboBox*)GetDlgItem(IDC_COMBO7))->SetCurSel(i);
			
		uColor = m_cTreeList.GetItemTextColor(m_hSelect,m_iSelCol);

		for(i=ENTRIES(aColors)-1;i>0;i--)
			{
			if(uColor==aColors[i])break;
			}

		((CComboBox*)GetDlgItem(IDC_COMBO8))->SetCurSel(i);
		
		
		memcpy(cUserData,m_cTreeList.GetUserData(m_hSelect),USER_DATA_SIZE);
		cUserData[sizeof(cUserData)-1]=0;
		}	


	((CButton*)GetDlgItem(IDC_CHECK19))->SetCheck((m_uSelState&TVIS_BOLD     )? 1:0);
	((CButton*)GetDlgItem(IDC_CHECK20))->SetCheck((m_uSelState&TVIS_UNTERLINE)? 1:0);
	((CButton*)GetDlgItem(IDC_CHECK21))->SetCheck((m_uSelState&TVIS_EXPANDED )? 1:0);

	
	SetDlgItemText(IDC_EDIT1,sCol     );
	SetDlgItemText(IDC_EDIT2,cText    );
	SetDlgItemText(IDC_EDIT4,cUserData);

	
	*pResult = 0;

}

//*****************************************************************************
//*
//*		OnItemExpanded
//*
//*****************************************************************************
void CTreeListDlg::OnItemExpanded(NMHDR *pNmHdr,LRESULT *pResult)
{
NM_TREEVIEW *pNmTreeView = (NM_TREEVIEW*)pNmHdr;



	*pResult = 0;

}

//*****************************************************************************
//*
//*		OnColumnClick
//*
//*****************************************************************************
void CTreeListDlg::OnColumnClick(NMHDR *pNmHdr,LRESULT *pResult)
{
NMHEADER *pNMHeader = (NMHEADER*)pNmHdr;
 



	*pResult = 0;

}


//*****************************************************************************
//*
//*		OnBeginLabelEdit
//*
//*****************************************************************************
void CTreeListDlg::OnBeginLabelEdit(NMHDR *pNmHdr,LRESULT *pResult)
{
NMTVDISPINFO *pHeader = (NMTVDISPINFO*)pNmHdr;
 

	*pResult = 0;

}

//*****************************************************************************
//*
//*		OnEndLabelEdit
//*
//*****************************************************************************
void CTreeListDlg::OnEndLabelEdit(NMHDR *pNmHdr,LRESULT *pResult)
{
NMTVDISPINFO   *pHeader = (NMTVDISPINFO*)pNmHdr;


	
	if(pHeader->item.mask&TVIF_TEXT)
	if(pHeader->item.pszText)
		{
		SetDlgItemText(IDC_EDIT2,pHeader->item.pszText);
		}

	*pResult = 0;


}


//*****************************************************************************
//*
//*		OnReturn
//*
//*****************************************************************************
void CTreeListDlg::OnReturn(NMHDR* pNMHDR, LRESULT* pResult)
{

	m_cTreeList.EditLabel(m_hSelect,m_iSelCol,1);

	*pResult = 0;

}

//*****************************************************************************
//*
//*		OnOK
//*
//*****************************************************************************
void CTreeListDlg::OnOK() 
{
	
	CDialog::OnOK();

}

//*****************************************************************************
//*
//*		OnCancel
//*
//*****************************************************************************
void CTreeListDlg::OnCancel() 
{
	
	CDialog::OnCancel();

}


//*****************************************************************************
//*
//*		OnChangeColor?
//*
//*****************************************************************************
void CTreeListDlg::OnChangeColor1(){m_cTreeList.SetColor(TVC_BK   ,aColors[((CComboBox*)GetDlgItem(IDC_COMBO1))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor2(){m_cTreeList.SetColor(TVC_TEXT ,aColors[((CComboBox*)GetDlgItem(IDC_COMBO2))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor3(){m_cTreeList.SetColor(TVC_ODD  ,aColors[((CComboBox*)GetDlgItem(IDC_COMBO3))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor4(){m_cTreeList.SetColor(TVC_EVEN ,aColors[((CComboBox*)GetDlgItem(IDC_COMBO4))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor5(){m_cTreeList.SetColor(TVC_FRAME,aColors[((CComboBox*)GetDlgItem(IDC_COMBO5))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor6(){m_cTreeList.SetColor(TVC_BOX  ,aColors[((CComboBox*)GetDlgItem(IDC_COMBO6))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor7(){m_cTreeList.SetItemBkColor  (m_hSelect,m_iSelCol,aColors[((CComboBox*)GetDlgItem(IDC_COMBO7))->GetCurSel()]);}
void CTreeListDlg::OnChangeColor8(){m_cTreeList.SetItemTextColor(m_hSelect,m_iSelCol,aColors[((CComboBox*)GetDlgItem(IDC_COMBO8))->GetCurSel()]);}






