namespace CommandServices
{
    /// <summary>
    /// 指令实现
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 指令关键字
        /// </summary>
        string CommandName { get; }
        /// <summary>
        /// 行为
        /// </summary>
        string Behavior { get; }
        /// <summary>
        /// 具体实现
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        void ExecuteOperation(params string[] parameters);
    }
}
