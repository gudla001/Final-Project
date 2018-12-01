using Xamarin.Forms;

namespace FinalProject
{
    public class Template : ContentPage
    {
        class TealTemplate : Grid
        {
            public TealTemplate()
            {
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) });
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.8, GridUnitType.Star) });
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) });
                ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.05, GridUnitType.Star) });
                ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.95, GridUnitType.Star) });

                var topBoxView = new BoxView { Color = Color.DarkGray };
                Children.Add(topBoxView, 0, 0);
                Grid.SetColumnSpan(topBoxView, 2);

               
            }
        }

        class AquaTemplate : Grid
        {
            public AquaTemplate()
            {
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) });
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.8, GridUnitType.Star) });
                RowDefinitions.Add(new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) });
                ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.05, GridUnitType.Star) });
                ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(0.95, GridUnitType.Star) });

                var topBoxView = new BoxView { Color = Color.DarkGray };
                Children.Add(topBoxView, 0, 0);
                Grid.SetColumnSpan(topBoxView, 2);

                var topLabel = new Label
                {
                    Text = "",
                    TextColor = Color.DarkGray,
                    VerticalOptions = LayoutOptions.Center
                };
                Children.Add(topLabel, 1, 0);

                var contentPresenter = new ContentPresenter();
                Children.Add(contentPresenter, 0, 1);
                Grid.SetColumnSpan(contentPresenter, 2);

                var bottomBoxView = new BoxView { Color = Color.DarkGray };
                Children.Add(bottomBoxView, 0, 2);
                Grid.SetColumnSpan(bottomBoxView, 2);

                var bottomLabel = new Label
                {
                    Text = "",
                    TextColor = Color.DarkGray,
                    VerticalOptions = LayoutOptions.Center
                };
                Children.Add(bottomLabel, 1, 2);
            }
        }

        bool originalTemplate = true;
        ControlTemplate tealTemplate = new ControlTemplate(typeof(TealTemplate));
        ControlTemplate aquaTemplate = new ControlTemplate(typeof(AquaTemplate));

        public Template()
        {
            var button = new Button { Text = "Black/Blue theme" };
            var contentView = new ContentView
            {
                Padding = new Thickness(0, 20, 0, 0),
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Children = {
                        new Label { Text = "Welcome to the app!", HorizontalOptions = LayoutOptions.Center },
                        button
                    }
                },
                ControlTemplate = tealTemplate
            };

            button.Clicked += (sender, e) => {
                originalTemplate = !originalTemplate;
                contentView.ControlTemplate = (originalTemplate) ? tealTemplate : aquaTemplate;
            };

            Content = contentView;
        }
    }
}
