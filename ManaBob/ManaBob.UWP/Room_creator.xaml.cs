using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 빈 페이지 항목 템플릿에 대한 설명은 http://go.microsoft.com/fwlink/?LinkId=234238에 나와 있습니다.

namespace ManaBob.UWP
{
    /// <summary>
    /// 자체적으로 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
    /// </summary>
    public sealed partial class Room_creator : Page
    {
        public Room_creator()
        {
            this.InitializeComponent();
        }

        private void kickout_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            this.Frame.Navigate(typeof(Room_User));
            // 추방 하기 기능이 있어야 할 자리이지만
            // 일단은 유저가 보는 방의 ui로 넘어갈 구실이 필요하여
            //room_user로 넘어가게 했습니다.

            //추방하기 버튼을 클릭하였을 때 
        }

        private void complete_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            this.Frame.Navigate(typeof(RoomView));
            // 마감하기 버튼을 눌렀을 때
            // 방의 목록들이 보이는 페이지로 이동하도록 하였습니다.
            // 방의 목록들이 보이는 창에서는 방의 정보가 삭제
        }

        private void report_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            //this.Frame.Navigate(typeof(Popup));
            // 팝업을 만들었는데 함수를 실행시키면 
            // nullpointexception 같은 에러가 나면서 
            // 프로그램이 종료됩니다.
            // navigate 말고 다른 걸 써야하는 지 그걸 잘 모르겠습니다.



        }

        private void roomout_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            this.Frame.Navigate(typeof(RoomView));
            // 방 나가기 버튼을 눌렀을 때 역시 
            // 방의 목록들이 보이는 페이지로 이동
            // 방의 목록들이 보이는 창에서는 방의 정보가 삭제되지 않음
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

            this.Frame.Navigate(typeof(CreateRoom));
            // 방 정보를 수정하는 페이지로 이동
            // 새로 수정하는 페이지를 만들이 않아도 될 것 같아서
            // 생성 하기 페이지와 같은 페이지로 연결했습니다.
        }

    }
}
