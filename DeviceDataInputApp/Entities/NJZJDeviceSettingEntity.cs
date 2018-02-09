using System;

namespace DeviceDataInputApp.Entities
{
    [Serializable]
    /// <summary>
    /// 设备更改上报参数
    /// 数据类型编号,此处为0
    /// </summary>
    public class NJZJDeviceSettingEntity
    {
        /// <summary>
        /// 设备编号  byte  20字节
        /// </summary>
        public string deviceNo;

        public string getDeviceNo()
        {
            return deviceNo;
        }
        [Attributes.Byte(ByteIndex = 0)]
        public void setDeviceNo(string deviceNo)
        {
            this.deviceNo = deviceNo;
        }
        public string nickName;
        /// <summary>
        /// 程序启动后从远程服务器获取数据，拿来装配
        /// </summary>
        /// <returns></returns>
        public string getNickName()
        {
            return nickName;
        }
        [Attributes.Byte(ByteIndex = 2)]
        public void setNickName(string nickName)
        {
            this.nickName = nickName;
        }
        #region ----------设备设定参数相关属性----------
        //设备类型
        public int power;

        /**
         * 获取设备类型
         *
         * @return power
         */

        public int getPower()
        {
            return power;
        }

        /**
         * 设置设备类型
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 32)]
        public void setPower(int data)
        {
            power = data;
        }

        //介质类型
        public int media;

        /**
         * 获取介质类型
         *
         * @return power
         */
        public int getMedia()
        {
            return media;
        }

        /**
         * 设置介质类型
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 34)]
        public void setMedia(int data)
        {
            media = data;
        }

        //运行状态
        public int runstatus;

        /**
         * 获取运行状态
         *
         * @return power
         */
        public int getRunstatus()
        {
            return runstatus;
        }

        /**
         * 设置运行状态
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 36)]
        public void setRunstatus(int data)
        {
            runstatus = data;
        }

        //排烟温度,单位："℃"
        public int paiyanwenduSetting;

        /**
         * 获取排烟温度
         *
         * @return paiyanwendu
         */
        public int getPaiYanWenDuSetting()
        {
            return paiyanwenduSetting;
        }

        /**
         * 设置排烟温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 38)]
        public void setPaiYanWenDuSetting(int data)
        {
            paiyanwenduSetting = data;
        }

        //报警温度,单位："℃"
        public int baojingwenduSetting;

        /**
         * 获取报警温度
         *
         * @return baojingwendu
         */
        public int getBaoJingWenDuSetting()
        {
            return baojingwenduSetting;
        }

        /**
         * 设置报警温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 40)]
        public void setBaoJingWenDuSetting(int data)
        {
            baojingwenduSetting = data;
        }

        //停炉温度,单位："℃"
        public int tingluwenduSetting;

        /**
         * 获取停炉温度
         *
         * @return tingluwendu
         */
        public int getTingLuWenDuSetting()
        {
            return tingluwenduSetting;
        }

        /**
         * 设置停炉温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 42)]
        public void setTingLuWenDuSetting(int data)
        {
            tingluwenduSetting = data;
        }

        //目标温度,单位："℃"
        public int mubiaowenduSetting;

        /**
         * 获取目标温度
         *
         * @return mubiaowendu
         */
        public int getMuBiaoWenDuSetting()
        {
            return mubiaowenduSetting;
        }

        /**
         * 设置目标温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 44)]
        public void setMuBiaoWenDuSetting(int data)
        {
            mubiaowenduSetting = data;
        }

        //启炉温度,单位："℃"
        public int qiluwenduSetting;

        /**
         * 获取启炉温度
         *
         * @return qiluwendu
         */
        public int getQiLuWenDuSetting()
        {
            return qiluwenduSetting;
        }

        /**
         * 设置启炉温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 46)]
        public void setQiLuWenDuSetting(int data)
        {
            qiluwenduSetting = data;
        }

        //转火回差,单位："℃"
        public int zhuanhuohuichaSetting;

        /**
         * 获取转火回差
         *
         * @return zhuanhuohuicha
         */
        public int getZhuanHuoHuiChaSetting()
        {
            return zhuanhuohuichaSetting;
        }

        /**
         * 设置转火回差
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 48)]
        public void setZhuanHuoHuiChaSetting(int data)
        {
            zhuanhuohuichaSetting = data;
        }

        //启炉回差,单位："℃"
        public int qiluhuichaSetting;

        /**
         * 获取启炉回差
         *
         * @return qiluhuicha
         */
        public int getQiLuHuiChaSetting()
        {
            return qiluhuichaSetting;
        }

        /**
         * 设置启炉回差
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 50)]
        public void setQiLuHuiChaSetting(int data)
        {
            qiluhuichaSetting = data;
        }

        //开泵温度,单位："℃"
        public int kaibengwenduSetting;

        /**
         * 获取开泵温度
         *
         * @return kaibengwendu
         */
        public int getKaiBengWenDuSetting()
        {
            return kaibengwenduSetting;
        }

        /**
         * 设置开泵温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 52)]
        public void setKaiBengWenDuSetting(int data)
        {
            kaibengwenduSetting = data;
        }

        //关泵温度,单位："℃"
        public int guanbengwenduSetting;

        /**
         * 获取关泵温度
         *
         * @return guanbengwendu
         */
        public int getGuanBengWenDuSetting()
        {
            return guanbengwenduSetting;
        }

        /**
         * 设置关泵温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 54)]
        public void setGuanBengWenDuSetting(int data)
        {
            guanbengwenduSetting = data;
        }

        //报警压力,单位："MPa"
        public int baojingyaliSetting;

        /**
         * 获取报警压力
         *
         * @return baojingyali
         */
        public int getBaoJingYaLiSetting()
        {
            return baojingyaliSetting;
        }

        /**
         * 设置报警压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 56)]
        public void setBaoJingYaLiSetting(int data)
        {
            baojingyaliSetting = data / 100;
        }

        //停炉压力,单位："MPa"
        public int tingluyaliSetting;

        /**
         * 获取停炉压力
         *
         * @return tingluyali
         */
        public int getTingLuYaLiSetting()
        {
            return tingluyaliSetting;
        }

        /**
         * 设置停炉压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 58)]
        public void setTingLuYaLiSetting(int data)
        {
            tingluyaliSetting = data / 100;
        }

        //目标压力,单位："MPa"
        public int mubiaoyaliSetting;

        /**
         * 获取目标压力
         *
         * @return mubiaoyali
         */
        public int getMuBiaoYaLiSetting()
        {
            return mubiaoyaliSetting;
        }

        /**
         * 设置目标压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 60)]
        public void setMuBiaoYaLiSetting(int data)
        {
            mubiaoyaliSetting = data / 100;
        }

        //启炉压力,单位："MPa"
        public int qiluyaliSetting;

        /**
         * 获取启炉压力
         *
         * @return qiluyali
         */
        public int getQiLuYaLiSetting()
        {
            return qiluyaliSetting;
        }

        /**
         * 设置启炉压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 62)]
        public void setQiLuYaLiSetting(int data)
        {
            qiluyaliSetting = data / 100;
        }

        //转火回差压力,单位："MPa"
        public int zhuanhuohuichayaliSetting;

        /**
         * 获取转火回差压力
         *
         * @return zhuanhuohuichayali
         */
        public int getZhuanHuoHuiChaYaLiSetting()
        {
            return zhuanhuohuichayaliSetting;
        }

        /**
         * 设置转火回差压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 64)]
        public void setZhuanHuoHuiChaYaLiSetting(int data)
        {
            zhuanhuohuichayaliSetting = data / 100;
        }

        //启炉回差压力,单位："MPa"
        public int qiluhuichayaliSetting;

        /**
         * 获取启炉回差压力
         *
         * @return qiluhuichayali
         */
        public int getQiLuHuiChaYaLiSetting()
        {
            return qiluhuichayaliSetting;
        }

        /**
         * 设置启炉回差压力
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 66)]
        public void setQiLuHuiChaYaLiSetting(int data)
        {
            qiluhuichayaliSetting = data / 100;
        }

        //前延时,单位："秒"
        public int qianyanshiSetting;
        /**
         * 获取前延时
         *
         * @return qianyanshi
         */

        public int getQianYanShiSetting()
        {
            return qianyanshiSetting;
        }

        /**
         * 设置前延时
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 68)]
        public void setQianYanShiSetting(int data)
        {
            qianyanshiSetting = data;
        }

        //后延时,单位："秒"
        public int houyanshiSetting;

        /**
         * 获取后延时
         *
         * @return houyanshi
         */

        public int getHouYanShiSetting()
        {
            return houyanshiSetting;
        }

        /**
         * 设置后延时
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 70)]
        public void setHouYanShiSetting(int data)
        {
            houyanshiSetting = data;
        }

        //前吹扫,单位："秒"
        public int qianchuisaoSetting;

        /**
         * 获取前吹扫
         *
         * @return qianchuisao
         */

        public int getQianChuiSaoSetting()
        {
            return qianchuisaoSetting;
        }

        /**
         * 设置前吹扫
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 72)]
        public void setQianChuiSaoSetting(int data)
        {
            qianchuisaoSetting = data;
        }

        //后吹扫,单位："秒"
        public int houchuisaoSetting;

        /**
         * 获取后吹扫
         *
         * @return houchuisao
         */

        public int getHouChuiSaoSetting()
        {
            return houchuisaoSetting;
        }

        /**
         * 设置后吹扫
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 74)]
        public void setHouChuiSaoSetting(int data)
        {
            houchuisaoSetting = data;
        }

        //炉壁报警温度,单位："℃"
        public int lubibaojingwenduSetting;

        /**
         * 获取炉壁报警温度
         *
         * @return lubibaojingwendu
         */

        public int getLuBiBaoJingWenDuSetting()
        {
            return lubibaojingwenduSetting;
        }

        /**
         * 设置炉壁报警温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 76)]
        public void setLuBiBaoJingWenDuSetting(int data)
        {
            lubibaojingwenduSetting = data;
        }

        //炉膛出口报警温度,单位："℃"
        public int lutangchukoubaojingwenduSetting;

        /**
         * 获取炉膛出口报警温度
         *
         * @return lutangchukoubaojingwendu
         */

        public int getLuTangChuKouBaoJingWenDuSetting()
        {
            return lutangchukoubaojingwenduSetting;
        }

        /**
         * 设置炉膛出口报警温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 78)]
        public void setLuTangChuKouBaoJingWenDuSetting(int data)
        {
            lutangchukoubaojingwenduSetting = data;
        }

        //保护温度,单位："℃"
        public int baohuwenduSetting;

        /**
         * 获取保护温度
         *
         * @return baohuwendu
         */

        public int getBaoHuWenDuSetting()
        {
            return baohuwenduSetting;
        }

        /**
         * 设置保护温度
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 80)]
        public void setBaoHuWenDuSetting(int data)
        {
            baohuwenduSetting = data;
        }

        //本体排烟温度报警值,单位："℃"
        public int bentipaiyanwendubaojingzhiSetting;

        /**
         * 获取本体排烟温度报警值
         *
         * @return bentipaiyanwendubaojingzhi
         */

        public int getBenTiPaiYanWenDuBaoJingZhiSetting()
        {
            return bentipaiyanwendubaojingzhiSetting;
        }

        /**
         * 设置本体排烟温度报警值
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 82)]
        public void setBenTiPaiYanWenDuBaoJingZhiSetting(int data)
        {
            bentipaiyanwendubaojingzhiSetting = data;
        }

        //启动时间1
        public int qidongshijian1Setting;

        /**
         * 获取启动时间1
         *
         * @return qidongshijian1
         */

        public int getQiDongShiJian1Setting()
        {
            return qidongshijian1Setting;
        }

        /**
         * 设置启动时间1
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 84)]
        public void setQiDongShiJian1Setting(int data)
        {
            qidongshijian1Setting = data;
        }

        //停止时间1
        public int tingzhishijian1Setting;

        /**
         * 获取停止时间1
         *
         * @return tingzhishijian1
         */

        public int getTingZhiShiJian1Setting()
        {
            return tingzhishijian1Setting;
        }

        /**
         * 设置停止时间1
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 86)]
        public void setTingZhiShiJian1Setting(int data)
        {
            tingzhishijian1Setting = data;
        }

        //启动时间2
        public int qidongshijian2Setting;

        /**
         * 获取启动时间2
         *
         * @return qidongshijian2
         */

        public int getQiDongShiJian2Setting()
        {
            return qidongshijian2Setting;
        }

        /**
         * 设置启动时间2
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 88)]
        public void setQiDongShiJian2Setting(int data)
        {
            qidongshijian2Setting = data;
        }

        //停止时间2
        public int tingzhishijian2Setting;

        /**
         * 获取停止时间2
         *
         * @return tingzhishijian2
         */

        public int getTingZhiShiJian2Setting()
        {
            return tingzhishijian2Setting;
        }

        /**
         * 设置停止时间2
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 90)]
        public void setTingZhiShiJian2Setting(int data)
        {
            tingzhishijian2Setting = data;
        }

        //启动时间3
        public int qidongshijian3Setting;

        /**
         * 获取启动时间3
         *
         * @return qidongshijian3
         */

        public int getQiDongShiJian3Setting()
        {
            return qidongshijian3Setting;
        }

        /**
         * 设置启动时间3
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 92)]
        public void setQiDongShiJian3Setting(int data)
        {
            qidongshijian3Setting = data;
        }

        //停止时间3
        public int tingzhishijian3Setting;

        /**
         * 获取停止时间3
         *
         * @return tingzhishijian3
         */

        public int getTingZhiShiJian3Setting()
        {
            return tingzhishijian3Setting;
        }

        /**
         * 设置停止时间3
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 94)]
        public void setTingZhiShiJian3Setting(int data)
        {
            tingzhishijian3Setting = data;
        }

        //启动时间4
        public int qidongshijian4Setting;

        /**
         * 获取启动时间4
         *
         * @return qidongshijian4
         */

        public int getQiDongShiJian4Setting()
        {
            return qidongshijian4Setting;
        }

        /**
         * 设置启动时间4
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 96)]
        public void setQiDongShiJian4Setting(int data)
        {
            qidongshijian4Setting = data;
        }

        //停止时间4
        public int tingzhishijian4Setting;

        /**
         * 获取停止时间4
         *
         * @return tingzhishijian4
         */

        public int getTingZhiShiJian4Setting()
        {
            return tingzhishijian4Setting;
        }

        /**
         * 设置停止时间4
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 98)]
        public void setTingZhiShiJian4Setting(int data)
        {
            tingzhishijian4Setting = data;
        }

        //启动时间5
        public int qidongshijian5Setting;

        /**
         * 获取启动时间5
         *
         * @return qidongshijian5
         */

        public int getQiDongShiJian5Setting()
        {
            return qidongshijian5Setting;
        }

        /**
         * 设置启动时间5
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 100)]
        public void setQiDongShiJian5Setting(int data)
        {
            qidongshijian5Setting = data;
        }

        //停止时间5
        public int tingzhishijian5Setting;

        /**
         * 获取停止时间5
         *
         * @return tingzhishijian5
         */

        public int getTingZhiShiJian5Setting()
        {
            return tingzhishijian5Setting;
        }

        /**
         * 设置停止时间5
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 102)]
        public void setTingZhiShiJian5Setting(int data)
        {
            tingzhishijian5Setting = data;
        }

        //启动时间6
        public int qidongshijian6Setting;

        /**
         * 获取启动时间6
         *
         * @return qidongshijian6
         */

        public int getQiDongShiJian6Setting()
        {
            return qidongshijian6Setting;
        }

        /**
         * 设置启动时间6
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 104)]
        public void setQiDongShiJian6Setting(int data)
        {
            qidongshijian6Setting = data;
        }

        //停止时间6
        public int tingzhishijian6Setting;

        /**
         * 获取停止时间6
         *
         * @return tingzhishijian6
         */

        public int getTingZhiShiJian6Setting()
        {
            return tingzhishijian6Setting;
        }

        /**
         * 设置停止时间6
         *
         * @param data
         */
        [Attributes.Byte(ByteIndex = 106)]
        public void setTingZhiShiJian6Setting(int data)
        {
            tingzhishijian6Setting = data;
        }

        #endregion
    }
}
