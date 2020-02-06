using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_div.Common
{
    class Messages
    {
        #region ログイン画面
        public static string NON_ID_MSG = "IDを入力してください。";
        public static string NON_PW_MSG = "パスワードを入力してください。";

        public static string SIGNING_MSG = "ログイン中です。";
        public static string YES_SIGN_MSG = "ログインができました。";
        public static string NO_SIGN_MSG = "ログインが失敗しました。";
        public static string NO_SIGN_DUP_MSG = "ログインユーザーが重複しています。";

        public static string CLOSE_MSG = "Do you really want to exit?";
        public static string REG_MSG = "登録中です。";
        public static string REG_OK_MSG = "登録が完了しました。";
        #endregion
    }
}
