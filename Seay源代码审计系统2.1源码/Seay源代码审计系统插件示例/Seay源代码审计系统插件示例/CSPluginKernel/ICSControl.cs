using System;
using System.Drawing;

namespace CSPluginKernel {

    public interface IfuncObject
    {

        void func_I_changtext(string text);

        void func_I_addtab(object control, string title);
	}

	/// <summary>
	/// ����������ʵ������ӿ�
	/// </summary>
    public interface IvarObject{

        /// <summary>
        /// ѡ���·��
        /// </summary>
        string var_iwebpath { get; set; }

        /// <summary>
        /// �ļ�����
        /// </summary>
        string var_ifileencoding { get; set; }


	}

	public enum Delegates {
		Delegate_ActiveDocumentChanged ,
	}

}