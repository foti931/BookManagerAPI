using System;

namespace Common
{
    public static class Constants
    {
        /// <summary>
        /// 接続情報名
        /// </summary>
        public static string CONNECTION_NAME = "MysqlConnection";
        /// <summary>
        /// 接続パスワード
        /// </summary>
        public static string CONNECTION_PASSWORD = "DbPassword";
    }

    /// <summary>
    /// メッセージクラス
    /// </summary>
    public static class CommonMessages
    {
        /// <summary>
        /// 例外メッセージ
        /// </summary>
        public static class ExceptionMessage
        {
            /// <summary>
            /// DB接続情報が見つかりません
            /// </summary>
            public static string CONNECTION_INFO_NOT_FOUND = "DB接続情報が見つかりません。";

            /// <summary>
            /// DB接続パスワードが見つかりません
            /// </summary>
            public static string CONNECTION_PASSWORD_NOT_FOUND = "DB接続パスワードが見つかりません。";
        }

        /// <summary>
        /// 一般メッセージ
        /// </summary>
        public static class NormalMessage
        {
        }
    }
}
