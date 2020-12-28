using System.ComponentModel.DataAnnotations.Schema;

namespace Leantek.Gateway.Model
{
    [Table("sys_service")]
    public class ServiceModel : DatabaseObject
    {
        public string Name { get; set; }
        public string ServiceType { get; set; }
        // 是否启用
        public int IsEnable { get; set; }
        // 是否代理
        public int IsAgency { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public int IsSSL { get; set; }
        public string SSHVerify { get; set; }
        // 客户端标识符
        public string ClientIdentifier { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        // 保持连接
        public int StayConnected { get; set; }

        // 间隔
        public int ReConnInterval { get; set; }

        // 超时时间
        public int Overtime { get; set; }

        // 主题
        public string Theme { get; set; }

        public int Qos { get; set; }
    }
}
