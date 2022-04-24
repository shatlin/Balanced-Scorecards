//*****************************************************************************
//*
//*
//*		TreeListDlg.h
//*
//*
//*****************************************************************************
#ifndef		AFX_TREELISTDLG_H__C9C3C776_6449_4E21_8D23_9B5ED42A4027__INCLUDED_
#define		AFX_TREELISTDLG_H__C9C3C776_6449_4E21_8D23_9B5ED42A4027__INCLUDED_	

#if _MSC_VER > 1000
#pragma once
#endif

#include	"TreeListCtrl.h"

//*****************************************************************************
//*
//*		CTreeListDlg
//*
//*****************************************************************************
class CTreeListDlg : public CDialog
{
public:
	CTreeListDlg(CWnd* pParent = NULL); 			

	//{{AFX_DATA(CTreeListDlg)
	enum { IDD = IDD_TREELIST_DIALOG };
	//}}AFX_DATA

	//{{AFX_VIRTUAL(CTreeListDlg)
protected:
	virtual void DoDataExchange(CDataExchange* pDX);
	//}}AFX_VIRTUAL

protected:

	HTREEITEM		m_hSelect;
	int				m_iSelCol;
	HICON			m_hIcon;
	CTreeListCtrl	m_cTreeList;
	CImageList		m_cImages;
	CString			m_sUserData;
	unsigned		m_uSelState;

	//{{AFX_MSG(CTreeListDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnCheck1();
	afx_msg void OnCheck2();
	afx_msg void OnCheck3();
	afx_msg void OnCheck4();
	afx_msg void OnCheck5();
	afx_msg void OnCheck6();
	afx_msg void OnCheck7();
	afx_msg void OnCheck8();
	afx_msg void OnCheck9();
	afx_msg void OnCheck10();
	afx_msg void OnCheck11();
	afx_msg void OnCheck12();
	afx_msg void OnCheck13();
	afx_msg void OnCheck14();
	afx_msg void OnCheck15();
	afx_msg void OnCheck16();
	afx_msg void OnCheck17();
	afx_msg void OnCheck18();
	afx_msg void OnCheck19();
	afx_msg void OnCheck20();
	afx_msg void OnCheck21();
	afx_msg void OnDrawItem(int nIDCtl, LPDRAWITEMSTRUCT lpDrawItemStruct);
	afx_msg void OnChangeColor1();
	afx_msg void OnChangeColor2();
	afx_msg void OnChangeColor3();
	afx_msg void OnChangeColor4();
	afx_msg void OnChangeColor5();
	afx_msg void OnChangeColor6();
	afx_msg void OnChangeColor7();
	afx_msg void OnChangeColor8();
	afx_msg void OnEdit();
	virtual void OnCancel();
	virtual void OnOK();
	afx_msg void OnCombo();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

	void OnCheck(int iID);
	void OnReturn        (NMHDR* pNMHDR, LRESULT* pResult);
	void OnSelChanged    (NMHDR* pNMHDR, LRESULT* pResult);
	void OnColumnClick   (NMHDR* pNMHDR, LRESULT* pResult);
	void OnItemExpanded  (NMHDR* pNMHDR, LRESULT* pResult);
	void OnEndLabelEdit	 (NMHDR* pNMHDR, LRESULT* pResult);
	void OnBeginLabelEdit(NMHDR* pNMHDR, LRESULT* pResult);
	
};

//{{AFX_INSERT_LOCATION}}

#endif
