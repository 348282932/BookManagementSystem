
namespace BookManagementSystem.Books
{
    public enum BookStatusEnum : byte
    {
        /// <summary>
        /// 正在连载
        /// </summary>
        Serialized = 1,

        /// <summary>
        /// 完本
        /// </summary>
        Finished = 2,

        /// <summary>
        /// 下架
        /// </summary>
        Shelved=3
    }
}
