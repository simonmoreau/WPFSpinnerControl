using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFSpinnerControl.MemberSelection
{
    public class MemberSelectionViewModel : BindableBase
    {
        private MemberSelectionItem _me;
        private MemberSelectionItem _notSetMember;

        public MemberSelectionViewModel()
        {
            

            OpenPopupCommand = new RelayCommand(OpenPopup);
            ClosePopupCommand = new RelayCommand(ClosePopup);

            SaveEditedSelectedMemberCommand = new RelayCommand(SaveEditedSelectedMember);
            CancelEditedSelectedMemberCommand = new RelayCommand(CancelEditedSelectedMember);

            SetMeAsSelectedMemberCommand = new RelayCommand(SetMeAsSelectedMember);
            RemoveMeAsSelectedMemberCommand = new RelayCommand(RemoveMeAsSelectedMember);

            MemberSelectionItems = new List<MemberSelectionItem>();

            _notSetMember = new MemberSelectionItem(null, "Not set", null, null);
            MemberSelectionItems.Add(_notSetMember);
            MemberSelectionItems.Add(new MemberSelectionItem("cedac9c7095a482795636ff48077b12b", "Dag Fjeld Edvardsen", "dag.fjeld.edvardsen@catenda.no", "https://api.bimsync.com/v2/avatar/lPrXS1omHZAVRAjnmjEWp%252FqM2IP3gL%252FttPE84T85MKcwJBcnsa0iwt1wF0LwJsjW"));
            MemberSelectionItems.Add(new MemberSelectionItem("e647607b020d4cb8950c1dfaf544ae1a", "Simon Moreau", "s.moreau@bouygues-immobilier.com", "https://api.bimsync.com/v2/avatar/fMBhCbVdH04LQux8nPywuo7U1QSq7HS2Mmo0i5%252FoJpswJBcnsa0iwt1wF0LwJsjW"));
            MemberSelectionItems.Add(new MemberSelectionItem("4f933018f5034991ae4691bbf1e141ed", "Alessandra Peroni", "a.peroni@bouygues-immobilier.com", "https://api.bimsync.com/v2/avatar/%252Bmtsw5sn9MKZwj7En8Pv2TO8bnTPYKZ9iOb5k9fsCkcwJBcnsa0iwt1wF0LwJsjW"));
            MemberSelectionItems.Add(new MemberSelectionItem("060db126f7ee4678beb5facb298bfdf5", "stanislas de champroux", "s.dechamproux@bouygues-immobilier.com", null));
            MemberSelectionItems.Add(new MemberSelectionItem("fd78e5ee080b4063b40e492041c4a9a9", "Bouygues Immobilier", null, "https://api.bimsync.com/v2/avatar/8dxk2e9HML1WQpnxozf2ASXkKT40l2MsPn4v7rqH3KcwJBcnsa0iwt1wF0LwJsjW"));

            _me = MemberSelectionItems[2];

            SelectedMember = MemberSelectionItems[2];
            EditedSelectedMember = SelectedMember;
        }

        private void RemoveMeAsSelectedMember()
        {
            SelectedMember = _notSetMember;
            IsPopupOpen = false;
        }

        private void SetMeAsSelectedMember()
        {
            SelectedMember = _me;
            IsPopupOpen = false;
        }

        private void CancelEditedSelectedMember()
        {
            EditedSelectedMember = SelectedMember;
            IsPopupOpen = false;
        }

        private void SaveEditedSelectedMember()
        {
            SelectedMember = EditedSelectedMember;
            IsPopupOpen = false;
        }

        private void ClosePopup()
        {
            IsPopupOpen = false;
        }

        private void OpenPopup()
        {
            IsPopupOpen = true;
        }

        private List<MemberSelectionItem> _memberSelectionItems;
        public List<MemberSelectionItem> MemberSelectionItems
        {
            get { return _memberSelectionItems; }
            set { SetProperty(ref _memberSelectionItems, value); }
        }

        private MemberSelectionItem _selectedMember;
        public MemberSelectionItem SelectedMember
        {
            get { return _selectedMember; }
            set { SetProperty(ref _selectedMember, value); CheckIfMeSelected(); }
        }

        private MemberSelectionItem _editedSelectedMember;
        public MemberSelectionItem EditedSelectedMember
        {
            get { return _editedSelectedMember; }
            set { SetProperty(ref _editedSelectedMember, value); }
        }

        private bool _isPopupOpen;
        public bool IsPopupOpen
        {
            get { return _isPopupOpen; }
            set { SetProperty(ref _isPopupOpen, value); }
        }

        private bool _isMeSelected;
        public bool IsMeSelected
        {
            get { return _isMeSelected; }
            set { SetProperty(ref _isMeSelected, value); }
        }

        private void CheckIfMeSelected()
        {
            if (SelectedMember == _me)
            {
                IsMeSelected = true;
            }
            else
            {
                IsMeSelected = false;
            }
        }



        public RelayCommand OpenPopupCommand { get; private set; }
        public RelayCommand ClosePopupCommand { get; private set; }

        public RelayCommand SaveEditedSelectedMemberCommand { get; private set; }
        public RelayCommand CancelEditedSelectedMemberCommand { get; private set; }

        public RelayCommand SetMeAsSelectedMemberCommand { get; private set; }
        public RelayCommand RemoveMeAsSelectedMemberCommand { get; private set; }


    }

    public class MemberSelectionItem : BindableBase
    {

        public MemberSelectionItem(string id, string name, string username, string url)
        {
            _id = id;
            _name = name;
            _username = username;
            _avatar = url == null ? null : new Uri(url, UriKind.Absolute);
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private Uri _avatar;
        public Uri Avatar
        {
            get { return _avatar; }
            set { SetProperty(ref _avatar, value); }
        }
    }
}
