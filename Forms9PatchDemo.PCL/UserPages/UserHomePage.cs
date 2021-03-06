using System;
using Xamarin.Forms;
using Forms9PatchDemo;

namespace Forms9PatchDemo
{
    class UserPagesHomePage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            /*
			var modal = new Forms9Patch.ModalPopup
			{
				Content = new Forms9Patch.StackLayout
				{
					Children = {
										new Xamarin.Forms.Label {
											Text = "Hello Modal popup!",
											TextColor = Color.Black}
									},
					BackgroundColor = Color.FromRgb(100, 100, 100),
					Padding = 20,
				},
				OutlineRadius = 4,
				OutlineWidth = 1,
				OutlineColor = Color.Black,
				BackgroundColor = Color.Aqua,
				HasShadow = true,
				HeightRequest = 200,
				WidthRequest = 200,
			};
			modal.BindingContext = this;
			modal.IsVisible = true;		
			*/
        }


        public UserPagesHomePage()
        {
            // Define command for the items in the TableView.
            var navigateCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    var page = (Page)Activator.CreateInstance(pageType);
                    await this.Navigation.PushAsync(page);
                });



            this.Title = "Forms Gallery";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot {
                    new TableSection("XAML") {
                        new TextCell
                        {
                            Text = "Stretch Issue Page",
                            Command = navigateCommand,
                            CommandParameter = typeof(StretchIssuePage)
                        },
                        new TextCell
                        {
                            Text = "SegmentBindingPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(SegmentBindingPage)
                        },
                        new TextCell {
                            Text = "Burkhart Test",
                            Command = navigateCommand,
                            CommandParameter = typeof(Burkhart)
                        },
                        new TextCell {
                            Text = "XAML: F9P Label in Xamarin.ListView",
                            Command = navigateCommand,
                            CommandParameter = typeof(XamlPageWithListViewWithF9PLabelInCells)
                        },
                    },

                    new TableSection("Code") {

                        new TextCell {
                            Text = "CODE: F9P Label in Xamarin.ListView",
                            Command = navigateCommand,
                            CommandParameter = typeof(ListViewWithF9PLabelInCells)
                        },

                        new TextCell {
                            Text = "ButtonTapped",
                            Command = navigateCommand,
                            CommandParameter = typeof(ButtonTapped)
                        },


                        new TextCell {
                            Text = "SegmentSelectedBackgroundPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(SegmentSelectedBackgroundPage)
                        },

                        new TextCell {
                            Text = "<br>",
                            Command = navigateCommand,
                            CommandParameter = typeof(br)
                        },

                        new TextCell {
                            Text = "ModalPopupOnMasterDetailPagel",
                            Command = navigateCommand,
                            CommandParameter = typeof(ModalPopupOnMasterDetailPage)
                        },

                        new TextCell {
                            Text = "ChrisEmbeddedResourceFontEffectPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(ChrisEmbeddedResourceFontEffectPage)
                        },


                        new TextCell {
                            Text = "ChatListPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(ChatListPage)
                        },


                        new TextCell {
                            Text = "ModalPopupWithNavigationPages",
                            Command = navigateCommand,
                            CommandParameter = typeof(ModalPopupWithNavigationPages)
                        },

                        new TextCell {
                            Text = "NestedBubblePopupPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(NestedBubblePopupPage)
                        },

                        new TextCell {
                            Text = "ZenmekPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(ZenmekPage)
                        },

                        new TextCell {
                            Text = "BackgroundImageOpacityPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(BackgroundImageOpacityPage)
                        },

                        new TextCell {
                            Text = "SegmentNavPage1",
                            Command = navigateCommand,
                            CommandParameter = typeof(SegmentNavPage1)
                        },

                        new TextCell {
                            Text = "AbsoluteLayoutExplorationCode",
                            Command = navigateCommand,
                            CommandParameter = typeof(AbsoluteLayoutExplorationCode)
                        },
                    }
                }
            };
        }
    }
}
