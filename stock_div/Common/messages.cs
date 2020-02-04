﻿using System;
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

        public static string YES_SIGN_MSG = "ログインができました。";
        public static string NO_SIGN_MSG = "ログインが失敗しました。";
        public static string NO_SIGN_DUP_MSG = "ログインユーザーが重複しています。";
        #endregion
    }
}