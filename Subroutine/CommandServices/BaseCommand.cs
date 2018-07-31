using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public abstract class BaseCommand : ICommand
    {
        /// <summary>
        /// 参数
        /// </summary>
        protected string[] parameters;

        /// <summary>
        /// 运行结果
        /// </summary>
        protected bool? isSuccess;

        /// <summary>
        /// 运行失败信息
        /// </summary>
        protected string failMsg;

        /// <summary>
        /// 行为，形容指令作用
        /// </summary>
        public abstract string Behavior
        {
            get;
        }

        /// <summary>
        /// 指令名
        /// </summary>
        public abstract string CommandName
        {
            get;
        }

        /// <summary>
        /// 是否可存储于日志
        /// </summary>
        protected abstract bool IsStorable
        {
            get;
        }

        /// <summary>
        /// 最大参数个数
        /// </summary>
        protected abstract int MaxParaNum
        {
            get;
        }

        /// <summary>
        /// 最小参数个数
        /// </summary>
        protected abstract int MinParaNum
        {
            get;
        }

        /// <summary>
        /// 执行流程
        /// </summary>
        /// <param name="parameters"></param>
        public void ExecuteOperation(params string[] parameters)
        {
            try
            {
                Prepare(parameters);
                Do();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                failMsg = ex.Message;
                Console.WriteLine($"指令运行失败！\n{ex.Message}");
            }
            finally
            {
                End();
            }
        }

        /// <summary>
        /// 指令执行前，准备工作
        /// </summary>
        /// <param name="parameters"></param>
        protected virtual void Prepare(string[] parameters)
        {
            this.parameters = parameters;
            IsValidPara();
        }

        /// <summary>
        /// 指令执行后，收尾工作
        /// </summary>
        protected virtual void End()
        {
            //日志记录
            if (this.IsStorable)
            {
                LogProcessor.RecordLog.RecordExecutiveOutcome(CommandName, Behavior, parameters, (bool)isSuccess, failMsg);
            }
            parameters = null;
            failMsg = null;
            isSuccess = null;
        }

        /// <summary>
        /// 参数是否规范
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected void IsValidPara()
        {
            string msg = $"{CommandName}指令的参数个数，规定为{MinParaNum}" + (MinParaNum == MaxParaNum ? "" : $"至{MaxParaNum}") + "个！";

            if (parameters == null)
            {
                if (MinParaNum != 0)
                {
                    throw new Exception(msg);
                }
            }
            else if (parameters.Length < MinParaNum || parameters.Length > MaxParaNum)
            {
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// 具体实现，核心代码
        /// </summary>
        /// <param name="parameters"></param>
        protected abstract void Do();
    }
}
