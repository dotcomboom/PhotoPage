<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Studio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Studio))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.SaveTemplateQAButton = New System.Windows.Forms.RibbonButton()
        Me.UndoQAButton = New System.Windows.Forms.RibbonButton()
        Me.RedoQAButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.CutButton = New System.Windows.Forms.RibbonButton()
        Me.CopyButton = New System.Windows.Forms.RibbonButton()
        Me.PasteButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.UndoButton = New System.Windows.Forms.RibbonButton()
        Me.RedoButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.FindButton = New System.Windows.Forms.RibbonButton()
        Me.ReplaceButton = New System.Windows.Forms.RibbonButton()
        Me.SelectAllButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.FeatureCheckButton = New System.Windows.Forms.RibbonButton()
        Me.AdvancedPreviewButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.TitleFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.DescriptionFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.FooterFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel6 = New System.Windows.Forms.RibbonPanel()
        Me.ContentFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.CoverPhotoFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel7 = New System.Windows.Forms.RibbonPanel()
        Me.FontsFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.TextColorFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.BackgroundColorFeatureButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab3 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel10 = New System.Windows.Forms.RibbonPanel()
        Me.PhotoClassButton = New System.Windows.Forms.RibbonButton()
        Me.VideoClassButton = New System.Windows.Forms.RibbonButton()
        Me.AudioClassButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel9 = New System.Windows.Forms.RibbonPanel()
        Me.HeadingClassButton = New System.Windows.Forms.RibbonButton()
        Me.ParagraphClassButton = New System.Windows.Forms.RibbonButton()
        Me.SeperatorClassButton = New System.Windows.Forms.RibbonButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CodeEditor = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.EditorMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealTimePreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenInBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewBrowser = New System.Windows.Forms.WebBrowser()
        Me.OpenTemplateDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveTemplateDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OrbMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BetaCentralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPhotoPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.VersionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PreviewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CodeEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditorMenu.SuspendLayout()
        Me.OrbMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.CaptionBarVisible = False
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(1, 1)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = CType(resources.GetObject("Ribbon1.OrbImage"), System.Drawing.Image)
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbText = ""
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.DropDownButtonVisible = False
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.SaveTemplateQAButton)
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.UndoQAButton)
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.RedoQAButton)
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.RibbonButton1)
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ribbon1.Size = New System.Drawing.Size(622, 115)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 2, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'SaveTemplateQAButton
        '
        Me.SaveTemplateQAButton.Image = CType(resources.GetObject("SaveTemplateQAButton.Image"), System.Drawing.Image)
        Me.SaveTemplateQAButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.SaveTemplateQAButton.SmallImage = CType(resources.GetObject("SaveTemplateQAButton.SmallImage"), System.Drawing.Image)
        Me.SaveTemplateQAButton.ToolTip = "Saves the open template."
        Me.SaveTemplateQAButton.ToolTipTitle = "Save Template"
        '
        'UndoQAButton
        '
        Me.UndoQAButton.Image = CType(resources.GetObject("UndoQAButton.Image"), System.Drawing.Image)
        Me.UndoQAButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.UndoQAButton.SmallImage = CType(resources.GetObject("UndoQAButton.SmallImage"), System.Drawing.Image)
        Me.UndoQAButton.ToolTip = "Reverses the latest action."
        Me.UndoQAButton.ToolTipTitle = "Undo"
        '
        'RedoQAButton
        '
        Me.RedoQAButton.Image = CType(resources.GetObject("RedoQAButton.Image"), System.Drawing.Image)
        Me.RedoQAButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RedoQAButton.SmallImage = CType(resources.GetObject("RedoQAButton.SmallImage"), System.Drawing.Image)
        Me.RedoQAButton.ToolTip = "Repeats the latest action."
        Me.RedoQAButton.ToolTipTitle = "Redo"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab1.Text = "Edit"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ButtonMoreEnabled = False
        Me.RibbonPanel1.ButtonMoreVisible = False
        Me.RibbonPanel1.Items.Add(Me.CutButton)
        Me.RibbonPanel1.Items.Add(Me.CopyButton)
        Me.RibbonPanel1.Items.Add(Me.PasteButton)
        Me.RibbonPanel1.Text = "Clipboard"
        '
        'CutButton
        '
        Me.CutButton.Image = CType(resources.GetObject("CutButton.Image"), System.Drawing.Image)
        Me.CutButton.SmallImage = CType(resources.GetObject("CutButton.SmallImage"), System.Drawing.Image)
        Me.CutButton.Text = "Cut"
        '
        'CopyButton
        '
        Me.CopyButton.Image = CType(resources.GetObject("CopyButton.Image"), System.Drawing.Image)
        Me.CopyButton.SmallImage = CType(resources.GetObject("CopyButton.SmallImage"), System.Drawing.Image)
        Me.CopyButton.Text = "Copy"
        '
        'PasteButton
        '
        Me.PasteButton.Image = CType(resources.GetObject("PasteButton.Image"), System.Drawing.Image)
        Me.PasteButton.SmallImage = CType(resources.GetObject("PasteButton.SmallImage"), System.Drawing.Image)
        Me.PasteButton.Text = "Paste"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ButtonMoreEnabled = False
        Me.RibbonPanel2.ButtonMoreVisible = False
        Me.RibbonPanel2.Items.Add(Me.UndoButton)
        Me.RibbonPanel2.Items.Add(Me.RedoButton)
        Me.RibbonPanel2.Text = "History"
        '
        'UndoButton
        '
        Me.UndoButton.Image = CType(resources.GetObject("UndoButton.Image"), System.Drawing.Image)
        Me.UndoButton.SmallImage = CType(resources.GetObject("UndoButton.SmallImage"), System.Drawing.Image)
        Me.UndoButton.Text = "Undo"
        '
        'RedoButton
        '
        Me.RedoButton.Image = CType(resources.GetObject("RedoButton.Image"), System.Drawing.Image)
        Me.RedoButton.SmallImage = CType(resources.GetObject("RedoButton.SmallImage"), System.Drawing.Image)
        Me.RedoButton.Text = "Redo"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ButtonMoreEnabled = False
        Me.RibbonPanel3.ButtonMoreVisible = False
        Me.RibbonPanel3.Items.Add(Me.FindButton)
        Me.RibbonPanel3.Items.Add(Me.ReplaceButton)
        Me.RibbonPanel3.Items.Add(Me.SelectAllButton)
        Me.RibbonPanel3.Text = "Editing"
        '
        'FindButton
        '
        Me.FindButton.Image = CType(resources.GetObject("FindButton.Image"), System.Drawing.Image)
        Me.FindButton.SmallImage = CType(resources.GetObject("FindButton.SmallImage"), System.Drawing.Image)
        Me.FindButton.Text = "Find"
        '
        'ReplaceButton
        '
        Me.ReplaceButton.Image = CType(resources.GetObject("ReplaceButton.Image"), System.Drawing.Image)
        Me.ReplaceButton.SmallImage = CType(resources.GetObject("ReplaceButton.SmallImage"), System.Drawing.Image)
        Me.ReplaceButton.Text = "Replace"
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Image = CType(resources.GetObject("SelectAllButton.Image"), System.Drawing.Image)
        Me.SelectAllButton.SmallImage = CType(resources.GetObject("SelectAllButton.SmallImage"), System.Drawing.Image)
        Me.SelectAllButton.Text = "Select All"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ButtonMoreEnabled = False
        Me.RibbonPanel4.ButtonMoreVisible = False
        Me.RibbonPanel4.Items.Add(Me.FeatureCheckButton)
        Me.RibbonPanel4.Items.Add(Me.AdvancedPreviewButton)
        Me.RibbonPanel4.Text = "Testing"
        '
        'FeatureCheckButton
        '
        Me.FeatureCheckButton.Image = CType(resources.GetObject("FeatureCheckButton.Image"), System.Drawing.Image)
        Me.FeatureCheckButton.SmallImage = CType(resources.GetObject("FeatureCheckButton.SmallImage"), System.Drawing.Image)
        Me.FeatureCheckButton.Text = "Feature Check"
        '
        'AdvancedPreviewButton
        '
        Me.AdvancedPreviewButton.Image = CType(resources.GetObject("AdvancedPreviewButton.Image"), System.Drawing.Image)
        Me.AdvancedPreviewButton.SmallImage = CType(resources.GetObject("AdvancedPreviewButton.SmallImage"), System.Drawing.Image)
        Me.AdvancedPreviewButton.Text = "Preview Settings"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel6)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel7)
        Me.RibbonTab2.Text = "Features"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ButtonMoreEnabled = False
        Me.RibbonPanel5.ButtonMoreVisible = False
        Me.RibbonPanel5.Items.Add(Me.TitleFeatureButton)
        Me.RibbonPanel5.Items.Add(Me.DescriptionFeatureButton)
        Me.RibbonPanel5.Items.Add(Me.FooterFeatureButton)
        Me.RibbonPanel5.Text = "Layout"
        '
        'TitleFeatureButton
        '
        Me.TitleFeatureButton.Image = CType(resources.GetObject("TitleFeatureButton.Image"), System.Drawing.Image)
        Me.TitleFeatureButton.SmallImage = CType(resources.GetObject("TitleFeatureButton.SmallImage"), System.Drawing.Image)
        Me.TitleFeatureButton.Text = "Title"
        '
        'DescriptionFeatureButton
        '
        Me.DescriptionFeatureButton.Image = CType(resources.GetObject("DescriptionFeatureButton.Image"), System.Drawing.Image)
        Me.DescriptionFeatureButton.SmallImage = CType(resources.GetObject("DescriptionFeatureButton.SmallImage"), System.Drawing.Image)
        Me.DescriptionFeatureButton.Text = "Description"
        '
        'FooterFeatureButton
        '
        Me.FooterFeatureButton.Image = CType(resources.GetObject("FooterFeatureButton.Image"), System.Drawing.Image)
        Me.FooterFeatureButton.SmallImage = CType(resources.GetObject("FooterFeatureButton.SmallImage"), System.Drawing.Image)
        Me.FooterFeatureButton.Text = "Footer Text"
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.ButtonMoreEnabled = False
        Me.RibbonPanel6.ButtonMoreVisible = False
        Me.RibbonPanel6.Items.Add(Me.ContentFeatureButton)
        Me.RibbonPanel6.Items.Add(Me.CoverPhotoFeatureButton)
        Me.RibbonPanel6.Text = "Content"
        '
        'ContentFeatureButton
        '
        Me.ContentFeatureButton.Image = CType(resources.GetObject("ContentFeatureButton.Image"), System.Drawing.Image)
        Me.ContentFeatureButton.SmallImage = CType(resources.GetObject("ContentFeatureButton.SmallImage"), System.Drawing.Image)
        Me.ContentFeatureButton.Text = "Main Content"
        '
        'CoverPhotoFeatureButton
        '
        Me.CoverPhotoFeatureButton.DropDownArrowSize = New System.Drawing.Size(0, 0)
        Me.CoverPhotoFeatureButton.Image = CType(resources.GetObject("CoverPhotoFeatureButton.Image"), System.Drawing.Image)
        Me.CoverPhotoFeatureButton.SmallImage = CType(resources.GetObject("CoverPhotoFeatureButton.SmallImage"), System.Drawing.Image)
        Me.CoverPhotoFeatureButton.Text = "Cover Photo Name"
        '
        'RibbonPanel7
        '
        Me.RibbonPanel7.ButtonMoreEnabled = False
        Me.RibbonPanel7.ButtonMoreVisible = False
        Me.RibbonPanel7.Items.Add(Me.FontsFeatureButton)
        Me.RibbonPanel7.Items.Add(Me.TextColorFeatureButton)
        Me.RibbonPanel7.Items.Add(Me.BackgroundColorFeatureButton)
        Me.RibbonPanel7.Text = "Customization"
        '
        'FontsFeatureButton
        '
        Me.FontsFeatureButton.Image = CType(resources.GetObject("FontsFeatureButton.Image"), System.Drawing.Image)
        Me.FontsFeatureButton.SmallImage = CType(resources.GetObject("FontsFeatureButton.SmallImage"), System.Drawing.Image)
        Me.FontsFeatureButton.Text = "Fonts"
        '
        'TextColorFeatureButton
        '
        Me.TextColorFeatureButton.Image = CType(resources.GetObject("TextColorFeatureButton.Image"), System.Drawing.Image)
        Me.TextColorFeatureButton.SmallImage = CType(resources.GetObject("TextColorFeatureButton.SmallImage"), System.Drawing.Image)
        Me.TextColorFeatureButton.Text = "Color 1"
        '
        'BackgroundColorFeatureButton
        '
        Me.BackgroundColorFeatureButton.Image = CType(resources.GetObject("BackgroundColorFeatureButton.Image"), System.Drawing.Image)
        Me.BackgroundColorFeatureButton.SmallImage = CType(resources.GetObject("BackgroundColorFeatureButton.SmallImage"), System.Drawing.Image)
        Me.BackgroundColorFeatureButton.Text = "Color 2"
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel10)
        Me.RibbonTab3.Panels.Add(Me.RibbonPanel9)
        Me.RibbonTab3.Text = "Classes"
        '
        'RibbonPanel10
        '
        Me.RibbonPanel10.ButtonMoreEnabled = False
        Me.RibbonPanel10.ButtonMoreVisible = False
        Me.RibbonPanel10.Items.Add(Me.PhotoClassButton)
        Me.RibbonPanel10.Items.Add(Me.VideoClassButton)
        Me.RibbonPanel10.Items.Add(Me.AudioClassButton)
        Me.RibbonPanel10.Text = "Media"
        '
        'PhotoClassButton
        '
        Me.PhotoClassButton.Image = CType(resources.GetObject("PhotoClassButton.Image"), System.Drawing.Image)
        Me.PhotoClassButton.SmallImage = CType(resources.GetObject("PhotoClassButton.SmallImage"), System.Drawing.Image)
        Me.PhotoClassButton.Text = "Photo"
        '
        'VideoClassButton
        '
        Me.VideoClassButton.Image = CType(resources.GetObject("VideoClassButton.Image"), System.Drawing.Image)
        Me.VideoClassButton.SmallImage = CType(resources.GetObject("VideoClassButton.SmallImage"), System.Drawing.Image)
        Me.VideoClassButton.Text = "Video"
        '
        'AudioClassButton
        '
        Me.AudioClassButton.Image = CType(resources.GetObject("AudioClassButton.Image"), System.Drawing.Image)
        Me.AudioClassButton.SmallImage = CType(resources.GetObject("AudioClassButton.SmallImage"), System.Drawing.Image)
        Me.AudioClassButton.Text = "Audio"
        '
        'RibbonPanel9
        '
        Me.RibbonPanel9.ButtonMoreEnabled = False
        Me.RibbonPanel9.ButtonMoreVisible = False
        Me.RibbonPanel9.Items.Add(Me.HeadingClassButton)
        Me.RibbonPanel9.Items.Add(Me.ParagraphClassButton)
        Me.RibbonPanel9.Items.Add(Me.SeperatorClassButton)
        Me.RibbonPanel9.Text = "Text"
        '
        'HeadingClassButton
        '
        Me.HeadingClassButton.Image = CType(resources.GetObject("HeadingClassButton.Image"), System.Drawing.Image)
        Me.HeadingClassButton.SmallImage = CType(resources.GetObject("HeadingClassButton.SmallImage"), System.Drawing.Image)
        Me.HeadingClassButton.Text = "Heading"
        '
        'ParagraphClassButton
        '
        Me.ParagraphClassButton.Image = CType(resources.GetObject("ParagraphClassButton.Image"), System.Drawing.Image)
        Me.ParagraphClassButton.SmallImage = CType(resources.GetObject("ParagraphClassButton.SmallImage"), System.Drawing.Image)
        Me.ParagraphClassButton.Text = "Paragraph"
        '
        'SeperatorClassButton
        '
        Me.SeperatorClassButton.Image = CType(resources.GetObject("SeperatorClassButton.Image"), System.Drawing.Image)
        Me.SeperatorClassButton.SmallImage = CType(resources.GetObject("SeperatorClassButton.SmallImage"), System.Drawing.Image)
        Me.SeperatorClassButton.Text = "Separator"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 113)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CodeEditor)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PreviewBrowser)
        Me.SplitContainer1.Size = New System.Drawing.Size(622, 258)
        Me.SplitContainer1.SplitterDistance = 382
        Me.SplitContainer1.TabIndex = 1
        '
        'CodeEditor
        '
        Me.CodeEditor.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.CodeEditor.AutoIndentCharsPatterns = ""
        Me.CodeEditor.AutoScrollMinSize = New System.Drawing.Size(419, 518)
        Me.CodeEditor.BackBrush = Nothing
        Me.CodeEditor.CharHeight = 14
        Me.CodeEditor.CharWidth = 8
        Me.CodeEditor.CommentPrefix = Nothing
        Me.CodeEditor.ContextMenuStrip = Me.EditorMenu
        Me.CodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeEditor.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeEditor.IsReplaceMode = False
        Me.CodeEditor.Language = FastColoredTextBoxNS.Language.HTML
        Me.CodeEditor.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.CodeEditor.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.CodeEditor.Location = New System.Drawing.Point(0, 0)
        Me.CodeEditor.Name = "CodeEditor"
        Me.CodeEditor.Paddings = New System.Windows.Forms.Padding(0)
        Me.CodeEditor.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.CodeEditor.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.CodeEditor.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CodeEditor.ServiceColors = CType(resources.GetObject("CodeEditor.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.CodeEditor.Size = New System.Drawing.Size(382, 258)
        Me.CodeEditor.TabIndex = 1
        Me.CodeEditor.Text = resources.GetString("CodeEditor.Text")
        Me.CodeEditor.Zoom = 100
        '
        'EditorMenu
        '
        Me.EditorMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem, Me.RealTimePreviewToolStripMenuItem, Me.ToolStripSeparator4, Me.OpenInBrowserToolStripMenuItem})
        Me.EditorMenu.Name = "ContextMenuStrip1"
        Me.EditorMenu.Size = New System.Drawing.Size(174, 148)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh Preview"
        '
        'RealTimePreviewToolStripMenuItem
        '
        Me.RealTimePreviewToolStripMenuItem.Checked = True
        Me.RealTimePreviewToolStripMenuItem.CheckOnClick = True
        Me.RealTimePreviewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RealTimePreviewToolStripMenuItem.Name = "RealTimePreviewToolStripMenuItem"
        Me.RealTimePreviewToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RealTimePreviewToolStripMenuItem.Text = "Real-Time Preview"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(170, 6)
        '
        'OpenInBrowserToolStripMenuItem
        '
        Me.OpenInBrowserToolStripMenuItem.Image = CType(resources.GetObject("OpenInBrowserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenInBrowserToolStripMenuItem.Name = "OpenInBrowserToolStripMenuItem"
        Me.OpenInBrowserToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpenInBrowserToolStripMenuItem.Text = "Preview in Browser"
        '
        'PreviewBrowser
        '
        Me.PreviewBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewBrowser.Location = New System.Drawing.Point(0, 0)
        Me.PreviewBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PreviewBrowser.Name = "PreviewBrowser"
        Me.PreviewBrowser.ScriptErrorsSuppressed = True
        Me.PreviewBrowser.Size = New System.Drawing.Size(236, 258)
        Me.PreviewBrowser.TabIndex = 0
        '
        'OpenTemplateDialog
        '
        Me.OpenTemplateDialog.DefaultExt = "ppgt"
        Me.OpenTemplateDialog.Filter = "PhotoPage Template (*.ppgt)|*.ppgt|HTML Document (*.html)|*.html"
        Me.OpenTemplateDialog.Title = "Open Template"
        '
        'SaveTemplateDialog
        '
        Me.SaveTemplateDialog.DefaultExt = "ppgt"
        Me.SaveTemplateDialog.Filter = "PhotoPage Template (*.ppgt)|*.ppgt|HTML Document (*.html)|*.html"
        Me.SaveTemplateDialog.Title = "Save Template"
        '
        'OrbMenu
        '
        Me.OrbMenu.BackColor = System.Drawing.Color.White
        Me.OrbMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator3, Me.BetaCentralToolStripMenuItem, Me.AboutPhotoPageToolStripMenuItem})
        Me.OrbMenu.Name = "OrbMenu"
        Me.OrbMenu.Size = New System.Drawing.Size(169, 126)
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'BetaCentralToolStripMenuItem
        '
        Me.BetaCentralToolStripMenuItem.Image = CType(resources.GetObject("BetaCentralToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BetaCentralToolStripMenuItem.Name = "BetaCentralToolStripMenuItem"
        Me.BetaCentralToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BetaCentralToolStripMenuItem.Text = "Beta Central"
        '
        'AboutPhotoPageToolStripMenuItem
        '
        Me.AboutPhotoPageToolStripMenuItem.Image = CType(resources.GetObject("AboutPhotoPageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutPhotoPageToolStripMenuItem.Name = "AboutPhotoPageToolStripMenuItem"
        Me.AboutPhotoPageToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutPhotoPageToolStripMenuItem.Text = "About PhotoPage"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionLabel, Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(622, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'VersionLabel
        '
        Me.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(53, 17)
        Me.VersionLabel.Text = "{version}"
        '
        'StatusLabel
        '
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(554, 17)
        Me.StatusLabel.Spring = True
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PreviewMenu
        '
        Me.PreviewMenu.Name = "ContextMenuStrip1"
        Me.PreviewMenu.Size = New System.Drawing.Size(61, 4)
        '
        'Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 392)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Ribbon1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Studio"
        Me.Text = "PhotoPage Studio - Untitled"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CodeEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditorMenu.ResumeLayout(False)
        Me.OrbMenu.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CodeEditor As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents EditorMenu As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents RibbonPanel5 As RibbonPanel
    Friend WithEvents RibbonPanel6 As RibbonPanel
    Friend WithEvents RibbonPanel7 As RibbonPanel
    Friend WithEvents OpenTemplateDialog As OpenFileDialog
    Friend WithEvents SaveTemplateDialog As SaveFileDialog
    Friend WithEvents SaveTemplateQAButton As RibbonButton
    Friend WithEvents UndoQAButton As RibbonButton
    Friend WithEvents RedoQAButton As RibbonButton
    Friend WithEvents CutButton As RibbonButton
    Friend WithEvents CopyButton As RibbonButton
    Friend WithEvents PasteButton As RibbonButton
    Friend WithEvents UndoButton As RibbonButton
    Friend WithEvents RedoButton As RibbonButton
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents FindButton As RibbonButton
    Friend WithEvents ReplaceButton As RibbonButton
    Friend WithEvents SelectAllButton As RibbonButton
    Friend WithEvents TitleFeatureButton As RibbonButton
    Friend WithEvents DescriptionFeatureButton As RibbonButton
    Friend WithEvents FooterFeatureButton As RibbonButton
    Friend WithEvents ContentFeatureButton As RibbonButton
    Friend WithEvents FontsFeatureButton As RibbonButton
    Friend WithEvents TextColorFeatureButton As RibbonButton
    Friend WithEvents BackgroundColorFeatureButton As RibbonButton
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents RibbonTab3 As RibbonTab
    Friend WithEvents PhotoClassButton As RibbonButton
    Friend WithEvents RibbonPanel9 As RibbonPanel
    Friend WithEvents OrbMenu As ContextMenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeadingClassButton As RibbonButton
    Friend WithEvents ParagraphClassButton As RibbonButton
    Friend WithEvents FeatureCheckButton As RibbonButton
    Friend WithEvents PreviewBrowser As WebBrowser
    Friend WithEvents RibbonPanel10 As RibbonPanel
    Friend WithEvents VideoClassButton As RibbonButton
    Friend WithEvents AudioClassButton As RibbonButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents VersionLabel As ToolStripStatusLabel
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BetaCentralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutPhotoPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RealTimePreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoverPhotoFeatureButton As RibbonButton
    Friend WithEvents SeperatorClassButton As RibbonButton
    Friend WithEvents AdvancedPreviewButton As RibbonButton
    Friend WithEvents PreviewMenu As ContextMenuStrip
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents OpenInBrowserToolStripMenuItem As ToolStripMenuItem
End Class
