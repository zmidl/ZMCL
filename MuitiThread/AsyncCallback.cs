using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting.Messaging;

namespace ZMCL.MuitiThread
{
	public class MyAsync
	{
		//public delegate void MethodReference();
		//public MethodReference AsyncDoWork;
		//public MethodReference AsyncComplete;
		//public MyAsync(Action work, Action complete)
		//{
		//	this.AsyncDoWork = new MethodReference(work);
		//	this.AsyncComplete = new MethodReference(complete);
		//}

		//public void BeginAsync()
		//{
		//	this.AsyncDoWork.BeginInvoke(new AsyncCallback(this.AsyncCallBack), this.AsyncDoWork);
		//}

		//private void AsyncCallBack(IAsyncResult iAsyncResult)
		//{
		//	AsyncResult asyncResult = (AsyncResult)iAsyncResult;
		//	if (asyncResult.IsCompleted == true)
		//	{
		//		AsyncComplete();
		//	}
		//}

	
		public Func<bool> AsyncDoWork;
		public Action AsyncSuccess;
		public Action AsyncFailed;

		public MyAsync(Func<bool> work,Action success,Action failed)
		{
			this.AsyncDoWork =work;
			this.AsyncSuccess = success;
			this.AsyncFailed = failed;
		}

		public void BeginAsync()
		{
			IAsyncResult result = this.AsyncDoWork.BeginInvoke(new AsyncCallback(this.CallBack), this.AsyncDoWork);
		}

		private void CallBack(IAsyncResult iAsyncResult)
		{
			AsyncResult asyncResult = (AsyncResult)iAsyncResult;
			Func<bool> asyncDelegate = (Func<bool>)asyncResult.AsyncDelegate;
			if (asyncDelegate.EndInvoke(iAsyncResult))
			{
				this.AsyncSuccess();
			}
			else
			{
				this.AsyncFailed();
			}
		}


	}
}
