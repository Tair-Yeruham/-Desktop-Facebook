using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using B22_Ex03.Enums;
using B22_Ex03.FactoryMethod;
using B22_Ex03.Features;
using B22_Ex03.Models;
using B22_Ex03.Strategy;
using FacebookWrapper;

namespace B22_Ex03.Forms
{
    public partial class FormSearchPostAndShowDetailsBasicExperience : Form, IFeatures
    {
        private const int k_DetailsCount = 7;
        private const int k_HeightOfCellInPostsDetailsTable = 40;
        private readonly SearchPostAndShowDetailsBasicExperience r_SearchPostAndShowDetailsBasicExperience;
        private readonly DataGridView r_PostsDetailsTable;
        private SortPostContext m_SortPostContext;
        private Dictionary<eSortTypes, Func<List<Posts>, List<Posts>>> m_LoadSortTypeOption; 

        public FormSearchPostAndShowDetailsBasicExperience(LoginResult i_LoginResult)
        {
            r_SearchPostAndShowDetailsBasicExperience = new SearchPostAndShowDetailsBasicExperience(i_LoginResult);
            r_PostsDetailsTable = new DataGridView();
            InitializeComponent();
            CenterToScreen();
            loadSearchTypesOption();
        }

        public void RunFeature()
        {
            ShowDialog();
        }

        private void loadSearchTypesOption()
        {
            m_LoadSortTypeOption = new Dictionary<eSortTypes, Func<List<Posts>, List<Posts>>>()
            {
                { eSortTypes.CreatedTime, (i_Posts) => displaySort(eSortTypes.CreatedTime, i_Posts) },
                { eSortTypes.LikesCount, (i_Posts) => displaySort(eSortTypes.LikesCount, i_Posts) },
                { eSortTypes.CommentsCount, (i_Posts) => displaySort(eSortTypes.CommentsCount, i_Posts) },
            };
            comboBoxSortType.DataSource = new BindingSource(m_LoadSortTypeOption, null);
            comboBoxSortType.DisplayMember = "Key";
            comboBoxSortType.ValueMember = "Value";
        }

        private List<Posts> displaySort(eSortTypes i_SortType, List<Posts> i_Posts)
        {
            m_SortPostContext = new SortPostContext(i_SortType, checkBoxShouldAscending.Checked);

            return m_SortPostContext.Sort(i_Posts);
        }

        private void buttonSearchPosts_Click(object i_Sender, EventArgs i_Event)
        {
            string searchPosts = textBoxSearchPosts.Text;
            List<Posts> postModel = r_SearchPostAndShowDetailsBasicExperience.SearchPosts(searchPosts);
            eSortTypes sortType = ((KeyValuePair<eSortTypes, Func<List<Posts>, List<Posts>>>) comboBoxSortType.SelectedItem).Key;

            if (postModel.Count == 0)
            {
                MessageBox.Show($@"There are no posts with '{searchPosts}' word");

                return;
            }

            postModel = m_LoadSortTypeOption[sortType].Invoke(postModel);
            displayDetailsTable(postModel);
        }

        private void displayDetailsTable(IReadOnlyCollection<Posts> i_Posts)
        {
            initializePostsDetailsTable();
            initializeRowHeaderInPostsDetailsTable();
            new Thread(() => initializePostsDetailsIntoTable(i_Posts)).Start();
            this.Controls.Add(r_PostsDetailsTable);
        }

        private void initializePostsDetailsTable()
        {
            r_PostsDetailsTable.ColumnHeadersVisible = false;
            r_PostsDetailsTable.RowHeadersVisible = false;
            r_PostsDetailsTable.Location = new Point(30, 70);
            r_PostsDetailsTable.Size = new Size(460, (k_HeightOfCellInPostsDetailsTable * k_DetailsCount) + k_HeightOfCellInPostsDetailsTable);
            r_PostsDetailsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            r_PostsDetailsTable.RowTemplate.Height = k_HeightOfCellInPostsDetailsTable;
            r_PostsDetailsTable.BackgroundColor = SystemColors.Control;
            r_PostsDetailsTable.BorderStyle = BorderStyle.None;
        }

        private void initializeRowHeaderInPostsDetailsTable()
        {
            r_PostsDetailsTable.RowCount = 7;
            r_PostsDetailsTable[0, 0].Value = @"Post";
            r_PostsDetailsTable[0, 1].Value = @"Created time";
            r_PostsDetailsTable[0, 2].Value = @"Link";
            r_PostsDetailsTable[0, 3].Value = @"Type";
            r_PostsDetailsTable[0, 4].Value = @"Comments count";
            r_PostsDetailsTable[0, 5].Value = @"Likes count";
            r_PostsDetailsTable[0, 6].Value = @"Hearts count";
        }

        private void initializePostsDetailsIntoTable(IReadOnlyCollection<Posts> i_Posts)
        {
            r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable.ColumnCount = 1 + i_Posts.Count));

            for(int i = 1; i <= i_Posts.Count; i++)
            {
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 0].Value = i_Posts.ElementAt(i - 1).Message));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 1].Value = i_Posts.ElementAt(i - 1).CreatedTime));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 2].Value = i_Posts.ElementAt(i - 1).Link));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 3].Value = i_Posts.ElementAt(i - 1).Type));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 4].Value = i_Posts.ElementAt(i - 1).CommentsCount));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 5].Value = i_Posts.ElementAt(i - 1).LikesCount));
                r_PostsDetailsTable.Invoke(new Action(() => r_PostsDetailsTable[i, 6].Value = i_Posts.ElementAt(i - 1).HeartsCount));
            }
        }
    }
}
