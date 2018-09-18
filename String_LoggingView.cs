using System;
using System.Collections.Generic;
using ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DEPS_Defines;

namespace DEPS_eNodeB_Debugger
{
    public partial class String_LoggingView : Forms
    {
        #region Defines
        public enum LayerType {L2, L3};
        #end region

        #region Constructor
        public String_LoggingView(string layer_name, int udp_port, LayerType layertype)
        {
            InitializeComponent();

            _layer_name = layer_name;
            _udp_port_no = udp_port;
            _layer_type = layertype;
        }
        #endregion

        #region Member
        
        LayerType _layer_type;
        bool _disply_timestemp = false;
        string _layer_name = “”;
        int _udp_port_no = 0;

        Timer _retrieve_timer = null;

        List<Defines.LogMessage> _log_message_list = null;
        object _log_message_list_sync_lock = new object();

        UDPReceiver _udp_receiver = null;
        FindStringMsgDlg _string_find_dlg;

        #endregion

        #region Methods

        public void Clear()
        {
            lock (_log_message_list_sync_lock)
            {
                listView_Message.VirtualListSize = 0;
                if(_log_message_list != null)
                    _log_message_list.Clear();
            }
            System.GC.Collect();
        }

        public void Load_logfile(string filename)
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke( new MethodInvoker(Delegate() {Load_logfile(filename); }));
                return ;
            }

            if(System.IO.)
        }

        #endregion
    }
}