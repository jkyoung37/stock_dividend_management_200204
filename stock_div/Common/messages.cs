using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_div.Common
{
    class Messages
    {
        public static string NON_ID_MSG = "IDを入力してください。";
        public static string NON_PW_MSG = "パスワードを入力してください。";

        public static string SIGNING_MSG = "ログイン中です。";
        public static string YES_SIGN_MSG = "ログインができました。";
        public static string NO_SIGN_MSG = "ログインが失敗しました。";
        public static string NO_SIGN_DUP_MSG = "ログインユーザーが重複しています。";

        public static string CLOSE_MSG = "Do you really want to exit?";
        public static string REG_MSG = "登録中です。";
        public static string REG_OK_MSG = "登録が完了しました。";
        public static string REG_EMPTY_MSG = "値を1件以上、入力してください。";

        public static string DEL_EMPTY_MSG = "値を1件以上、入力してください。";
        public static string DEL_OK_MSG = "削除が完了しました。";

        public static string HISTORY_CONNECT_MSG = "履歴データ取得中です。";

        public static string NETASSET_NUM_NO_MSG = "数値を入力をしてください。";
    }
}
