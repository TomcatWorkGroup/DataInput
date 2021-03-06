﻿using System;

namespace DeviceDataInputApp.Entities
{
    [Serializable]
    /// <summary>
    /// 设备实时上报参数
    /// </summary>
    public class NJZJDeviceRunEntity
    {
        //设备编号
        public string deviceNo;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getDeviceNo()
        {
            return deviceNo;
        }
        [Attributes.Byte(StartIndex = 0, Length = 1)]
        public void setDeviceNo(string deviceNo)
        {
            this.deviceNo = deviceNo;
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

        [Attributes.Byte(StartIndex = 20, Length = 1)]
        public void setRunstatus(int data)
        {
            runstatus = data;
        }
        #region ----------设备运行时间(运行状态)----------
        //设备运行天数
        public int rundays;
        //设备运行小时数
        public int runhours;
        public int getRunDays()
        {
            return rundays;
        }
        [Attributes.Byte(StartIndex = 21, Length = 2)]
        public void setRunDays(int runDays)
        {
            this.rundays = runDays;
        }
        public int getRunHours()
        {
            return runhours;
        }
        [Attributes.Byte(StartIndex = 23, Length = 2)]
        public void setRunHours(int runHours)
        {
            this.runhours = runHours;
        }
        #endregion
        public int power;
        public int getPower()
        {
            return power;
        }
        [Attributes.Byte(StartIndex = 25, Length = 1)]
        public void setPower(int data)
        {
            power = data;
        }

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
        [Attributes.Byte(StartIndex = 26, Length = 1)]
        public void setMedia(int data)
        {
            media = data;
        }

        public string nickName;
        public string getNickName()
        {
            return nickName;
        }
        [Attributes.Byte(StartIndex = 2, Length = 1)]
        public void setNickName(string nickName)
        {
            this.nickName = nickName;
        }
       
        #region ----------设备报警信息相关属性(运行状态)----------
        //排烟温度高
        public int paiyanwendugao;
        /**
         * 获取排烟温度高
         *
         * @return paiyanwendugao
         */
        public int getPaiYanWenDuGao()
        {
            return paiyanwendugao;
        }
        /**
         * 设置排烟温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 32, Length = 1)]
        public void setPaiYanWenDuGao(int data)
        {
            paiyanwendugao = data;
        }
        //炉水温度高
        public int lushuiwendugao;
        /**
         * 获取炉水温度高
         *
         * @return lushuiwendugao
         */
        public int getLuShuiWenDuGao()
        {
            return lushuiwendugao;
        }
        /**
         * 设置炉水温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 33, Length = 1)]
        public void setLuShuiWenDuGao(int data)
        {
            lushuiwendugao = data;
        }
        //出口温度高
        public int chukouwendugao;
        /**
         * 获取出口温度高
         *
         * @return chukouwendugao
         */

        public int getChuKouWenDuGao()
        {
            return chukouwendugao;
        }
        /**
         * 设置出口温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 34, Length = 1)]
        public void setChuKouWenDuGao(int data)
        {
            chukouwendugao = data;
        }
        //超压
        public int chaoya;
        /**
         * 获取超压
         *
         * @return chaoya
         */
        public int getChaoYa()
        {
            return chaoya;
        }
        /**
         * 设置超压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 35, Length = 1)]
        public void setChaoYa(int data)
        {
            chaoya = data;
        }
        //极限低水位
        public int jixiandishuiwei;
        /**
         * 获取极限低水位
         *
         * @return jixiandishuiwei
         */
        public int getJiXianDiShuiWei()
        {
            return jixiandishuiwei;
        }
        /**
         * 设置极限低水位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 36, Length = 1)]
        public void setJiXianDiShuiWei(int data)
        {
            jixiandishuiwei = data;
        }
        //低水位
        public int dishuiwei;
        /**
         * 获取低水位
         *
         * @return dishuiwei
         */

        public int getDiShuiWei()
        {
            return dishuiwei;
        }
        /**
         * 设置低水位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 37, Length = 1)]
        public void setDiShuiWei(int data)
        {
            dishuiwei = data;
        }
        //高水位
        public int gaoshuiwei;
        /**
         * 获取高水位
         *
         * @return gaoshuiwei
         */
        public int getGaoShuiWei()
        {
            return gaoshuiwei;
        }
        /**
         * 设置高水位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 38, Length = 1)]
        public void setGaoShuiWei(int data)
        {
            gaoshuiwei = data;
        }
        //水位信号逻辑错
        public int shuiweixinhaoluojicuo;
        /**
         * 获取水位信号逻辑错
         *
         * @return shuiweixinhaoluojicuo
         */
        public int getShuiWeiXinHaoLuoJiCuo()
        {
            return shuiweixinhaoluojicuo;
        }
        /**
         * 设置水位信号逻辑错
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 39, Length = 1)]
        public void setShuiWeiXinHaoLuoJiCuo(int data)
        {
            shuiweixinhaoluojicuo = data;
        }
        //炉壁温度高
        public int lubiwendugao;

        /**
         * 获取炉壁温度高
         *
         * @return lubiwendugao
         */

        public int getLuBiWenDuGao()
        {
            return lubiwendugao;
        }
        /**
         * 设置炉壁温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 40, Length = 1)]
        public void setLuBiWenDuGao(int data)
        {
            lubiwendugao = data;
        }
        //负压蒸汽温度高
        public int fuyazhengqiwendugao;
        /**
         * 获取负压蒸汽温度高
         *
         * @return fuyazhengqiwendugao
         */

        public int getFuYaZhengQiWenDuGao()
        {
            return fuyazhengqiwendugao;
        }
        /**
         * 设置负压蒸汽温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 41, Length = 1)]
        public void setFuYaZhengQiWenDuGao(int data)
        {
            fuyazhengqiwendugao = data;
        }
        //燃烧器故障
        public int ranshaoqiguzhang;
        /**
         * 获取燃烧器故障
         *
         * @return ranshaoqiguzhang
         */

        public int getRanShaoQiGuZhang()
        {
            return ranshaoqiguzhang;
        }
        /**
         * 设置燃烧器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 42, Length = 1)]
        public void setRanShaoQiGuZhang(int data)
        {
            ranshaoqiguzhang = data;
        }
        //燃气泄漏
        public int ranqixielou;
        /**
         * 获取燃气泄漏
         *
         * @return ranqixielou
         */

        public int getRanQiXieLou()
        {
            return ranqixielou;
        }
        /**
         * 设置燃气泄漏
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 43, Length = 1)]
        public void setRanQiXieLou(int data)
        {
            ranqixielou = data;
        }
        //燃气压力低
        public int ranqiyalidi;
        /**
         * 获取燃气压力低
         *
         * @return ranqiyalidi
         */

        public int getRanQiYaLiDi()
        {
            return ranqiyalidi;
        }
        /**
         * 设置燃气压力低
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 44, Length = 1)]
        public void setRanQiYaLiDi(int data)
        {
            ranqiyalidi = data;
        }
        //燃气压力异常
        public int ranqiyaliyichang;
        /**
         * 获取燃气压力异常
         *
         * @return ranqiyaliyichang
         */

        public int getRanQiYaLiYiChang()
        {
            return ranqiyaliyichang;
        }
        /**
         * 设置燃气压力异常
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 45, Length = 1)]
        public void setRanQiYaLiYiChang(int data)
        {
            ranqiyaliyichang = data;
        }
        //燃气压力高
        public int ranqiyaligao;
        /**
         * 获取燃气压力高
         *
         * @return ranqiyaligao
         */
        public int getRanQiYaLiGao()
        {
            return ranqiyaligao;
        }
        /**
         * 设置燃气压力高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 46, Length = 1)]
        public void setRanQiYaLiGao(int data)
        {
            ranqiyaligao = data;
        }
        //给水变频器故障
        public int jishuibianpinqiguzhang;
        /**
         * 获取给水变频器故障
         *
         * @return jishuibianpinqiguzhang
         */
        public int getJiShuiBianPinQiGuZhang()
        {
            return jishuibianpinqiguzhang;
        }
        /**
         * 设置给水变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 47, Length = 1)]
        public void setJiShuiBianPinQiGuZhang(int data)
        {
            jishuibianpinqiguzhang = data;
        }
        //循环变频器故障
        public int xunhuanbianpinqiguzhang;
        /**
         * 获取循环变频器故障
         *
         * @return xunhuanbianpinqiguzhang
         */
        public int getXunHuanBianPinQiGuZhang()
        {
            return xunhuanbianpinqiguzhang;
        }
        /**
         * 设置循环变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 48, Length = 1)]
        public void setXunHuanBianPinQiGuZhang(int data)
        {
            xunhuanbianpinqiguzhang = data;
        }
        //引风变频器故障
        public int yinfengbianpinqiguzhang;
        /**
         * 获取引风变频器故障
         *
         * @return yinfengbianpinqiguzhang
         */
        public int getYinFengBianPinQiGuZhang()
        {
            return yinfengbianpinqiguzhang;
        }
        /**
         * 设置引风变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 49, Length = 1)]
        public void setYinFengBianPinQiGuZhang(int data)
        {
            yinfengbianpinqiguzhang = data;
        }
        //鼓风变频器故障
        public int gufengbianpinqiguzhang;
        /**
         * 获取鼓风变频器故障
         *
         * @return gufengbianpinqiguzhang
         */

        public int getGuFengBianPinQiGuZhang()
        {
            return gufengbianpinqiguzhang;
        }
        /**
         * 设置鼓风变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 50, Length = 1)]
        public void setGuFengBianPinQiGuZhang(int data)
        {
            gufengbianpinqiguzhang = data;
        }
        //二次鼓风变频器故障
        public int ecigufengbianpinqiguzhang;
        /**
         * 获取二次鼓风变频器故障
         *
         * @return ecigufengbianpinqiguzhang
         */

        public int getECiGuFengBianPinQiGuZhang()
        {
            return ecigufengbianpinqiguzhang;
        }
        /**
         * 设置二次鼓风变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 51, Length = 1)]
        public void setECiGuFengBianPinQiGuZhang(int data)
        {
            ecigufengbianpinqiguzhang = data;
        }
        //炉排变频器故障
        public int lupaibianpinqiguzhang;
        /**
         * 获取炉排变频器故障
         *
         * @return lupaibianpinqiguzhang
         */
        public int getLuPaiBianPinQiGuZhang()
        {
            return lupaibianpinqiguzhang;
        }
        /**
         * 设置炉排变频器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 52, Length = 1)]
        public void setLuPaiBianPinQiGuZhang(int data)
        {
            lupaibianpinqiguzhang = data;
        }
        //给水泵故障
        public int jishuibengguzhang;
        /**
         * 获取给水泵故障
         *
         * @return jishuibengguzhang
         */
        public int getJiShuiBengGuZhang()
        {
            return jishuibengguzhang;
        }
        /**
         * 设置给水泵故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 53, Length = 1)]
        public void setJiShuiBengGuZhang(int data)
        {
            jishuibengguzhang = data;
        }
        //循环泵故障
        public int xunhuanbengguzhang;
        /**
         * 获取循环泵故障
         *
         * @return xunhuanbengguzhang
         */
        public int getXunHuanBengGuZhang()
        {
            return xunhuanbengguzhang;
        }
        /**
         * 设置循环泵故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 54, Length = 1)]
        public void setXunHuanBengGuZhang(int data)
        {
            xunhuanbengguzhang = data;
        }
        //循环系统欠压
        public int xunhuanxitongqianya;
        /**
         * 获取循环系统欠压
         *
         * @return xunhuanxitongqianya
         */
        public int getXunHuanXiTongQianYa()
        {
            return xunhuanxitongqianya;
        }
        /**
         * 设置循环系统欠压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 55, Length = 1)]
        public void setXunHuanXiTongQianYa(int data)
        {
            xunhuanxitongqianya = data;
        }
        //低电压
        public int didianya;
        /**
         * 获取低电压
         *
         * @return didianya
         */

        public int getDiDianYa()
        {
            return didianya;
        }
        /**
         * 设置低电压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 56, Length = 1)]
        public void setDiDianYa(int data)
        {
            didianya = data;
        }

        //高电压
        public int gaodianya;

        /**
         * 获取高电压
         *
         * @return gaodianya
         */

        public int getGaoDianYa()
        {
            return gaodianya;
        }

        /**
         * 设置高电压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 57, Length = 1)]
        public void setGaoDianYa(int data)
        {
            gaodianya = data;
        }

        //缺相
        public int quexiang;

        /**
         * 获取缺相
         *
         * @return quexiang
         */

        public int getQueXiang()
        {
            return quexiang;
        }

        /**
         * 设置缺相
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 58, Length = 1)]
        public void setQueXiang(int data)
        {
            quexiang = data;
        }

        //漏电
        public int loudian;

        /**
         * 获取漏电
         *
         * @return loudian
         */

        public int getLouDian()
        {
            return loudian;
        }

        /**
         * 设置漏电
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 59, Length = 1)]
        public void setLouDian(int data)
        {
            loudian = data;
        }

        //变送器过压保护
        public int biansongqiguoyabaohu;

        /**
         * 获取变送器过压保护
         *
         * @return biansongqiguoyabaohu
         */

        public int getBianSongQiGuoYaBaoHu()
        {
            return biansongqiguoyabaohu;
        }

        /**
         * 设置变送器过压保护
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 60, Length = 1)]
        public void setBianSongQiGuoYaBaoHu(int data)
        {
            biansongqiguoyabaohu = data;
        }

        //关键参数异常
        public int guanjiancanshuyichang;

        /**
         * 获取关键参数异常
         *
         * @return guanjiancanshuyichang
         */

        public int getGuanJianCanShuYiChang()
        {
            return guanjiancanshuyichang;
        }

        /**
         * 设置关键参数异常
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 61, Length = 1)]
        public void setGuanJianCanShuYiChang(int data)
        {
            guanjiancanshuyichang = data;
        }

        //设定参数异常
        public int shedingcanshuyichang;

        /**
         * 获取设定参数异常
         *
         * @return shedingcanshuyichang
         */

        public int getSheDingCanShuYiChang()
        {
            return shedingcanshuyichang;
        }

        /**
         * 设置设定参数异常
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 62, Length = 1)]
        public void setSheDingCanShuYiChang(int data)
        {
            shedingcanshuyichang = data;
        }

        //时钟故障
        public int shizhongguzhang;

        /**
         * 获取时钟故障
         *
         * @return shizhongguzhang
         */

        public int getShiZhongGuZhang()
        {
            return shizhongguzhang;
        }

        /**
         * 设置时钟故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 63, Length = 1)]
        public void setShiZhongGuZhang(int data)
        {
            shizhongguzhang = data;
        }

        //存储器故障
        public int cunchuqiguzhang;

        /**
         * 获取存储器故障
         *
         * @return cunchuqiguzhang
         */

        public int getCunChuQiGuZhang()
        {
            return cunchuqiguzhang;
        }

        /**
         * 设置存储器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 64, Length = 1)]
        public void setCunChuQiGuZhang(int data)
        {
            cunchuqiguzhang = data;
        }

        //外部连锁
        public int waibuliansuo;

        /**
         * 获取外部连锁
         *
         * @return waibuliansuo
         */

        public int getWaiBuLianSuo()
        {
            return waibuliansuo;
        }

        /**
         * 设置外部连锁
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 65, Length = 1)]
        public void setWaiBuLianSuo(int data)
        {
            waibuliansuo = data;
        }

        //缺油
        public int queyou;

        /**
         * 获取缺油
         *
         * @return queyou
         */

        public int getQueYou()
        {
            return queyou;
        }

        /**
         * 设置缺油
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 66, Length = 1)]
        public void setQueYou(int data)
        {
            queyou = data;
        }

        //低油位
        public int diyouwei;

        /**
         * 获取低油位
         *
         * @return diyouwei
         */

        public int getDiYouWei()
        {
            return diyouwei;
        }

        /**
         * 设置低油位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 67, Length = 1)]
        public void setDiYouWei(int data)
        {
            diyouwei = data;
        }

        //本体排烟温度高
        public int bentipaiyanwendugao;

        /**
         * 获取本体排烟温度高
         *
         * @return bentipaiyanwendugao
         */

        public int getBenTiPaiYanWenDuGao()
        {
            return bentipaiyanwendugao;
        }

        /**
         * 设置本体排烟温度高
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 68, Length = 1)]
        public void setBenTiPaiYanWenDuGao(int data)
        {
            bentipaiyanwendugao = data;
        }

        #endregion
        #region ----------设备故障信息相关属性(运行状态)----------
        //本体排烟温度传感器故障
        public int bentipaiyanwenduerror;

        /**
         * 获取本体排烟温度传感器故障
         *
         * @return bentipaiyanwendu
         */

        public int getBenTiPaiYanWenDuError()
        {
            return bentipaiyanwenduerror;
        }

        /**
         * 设置本体排烟温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 96, Length = 1)]
        public void setBenTiPaiYanWenDuError(int data)
        {
            bentipaiyanwenduerror = data;
        }

        //排烟温度传感器故障
        public int paiyanwenduerror;

        /**
         * 获取排烟温度传感器故障
         *
         * @return paiyanwendu
         */

        public int getPaiYanWenDuError()
        {
            return paiyanwenduerror;
        }

        /**
         * 设置排烟温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 97, Length = 1)]
        public void setPaiYanWenDuError(int data)
        {
            paiyanwenduerror = data;
        }

        //炉水温度传感器故障
        public int lushuiwenduerror;

        /**
         * 获取炉水温度传感器故障
         *
         * @return lushuiwendu
         */

        public int getLuShuiWenDuError()
        {
            return lushuiwenduerror;
        }

        /**
         * 设置炉水温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 98, Length = 1)]
        public void setLuShuiWenDuError(int data)
        {
            lushuiwenduerror = data;
        }

        //出口温度传感器故障
        public int chukouwenduerror;

        /**
         * 获取出口温度传感器故障
         *
         * @return chukouwendu
         */

        public int getChuKouWenDuError()
        {
            return chukouwenduerror;
        }

        /**
         * 设置出口温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 99, Length = 1)]
        public void setChuKouWenDuError(int data)
        {
            chukouwenduerror = data;
        }

        //入口温度传感器故障
        public int rukouwenduerror;

        /**
         * 获取入口温度传感器故障
         *
         * @return rukouwendu
         */

        public int getRuKouWenDuError()
        {
            return rukouwenduerror;
        }

        /**
         * 设置入口温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 100, Length = 1)]
        public void setRuKouWenDuError(int data)
        {
            rukouwenduerror = data;
        }

        //节能器出口温度传感器故障
        public int jienengqichukouwenduerror;

        /**
         * 获取节能器出口温度传感器故障
         *
         * @return jienengqichukouwendu
         */

        public int getJieNengQiChuKouWenDuError()
        {
            return jienengqichukouwenduerror;
        }

        /**
         * 设置节能器出口温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 101, Length = 1)]
        public void setJieNengQiChuKouWenDuError(int data)
        {
            jienengqichukouwenduerror = data;
        }

        //节能器入口温度传感器故障
        public int jienengqirukouwenduerror;

        /**
         * 获取节能器入口温度传感器故障
         *
         * @return jienengqirukouwendu
         */

        public int getJieNengQiRuKouWenDuError()
        {
            return jienengqirukouwenduerror;
        }

        /**
         * 设置节能器入口温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 102, Length = 1)]
        public void setJieNengQiRuKouWenDuError(int data)
        {
            jienengqirukouwenduerror = data;
        }

        //给水温度传感器故障
        public int jishuiwenduerror;

        /**
         * 获取给水温度传感器故障
         *
         * @return jishuiwendu
         */

        public int getJiShuiWenDuError()
        {
            return jishuiwenduerror;
        }

        /**
         * 设置给水温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 103, Length = 1)]
        public void setJiShuiWenDuError(int data)
        {
            jishuiwenduerror = data;
        }

        //炉膛温度传感器故障
        public int lutangwenduerror;

        /**
         * 获取炉膛温度传感器故障
         *
         * @return lutangwendu
         */

        public int getLuTangWenDuError()
        {
            return lutangwenduerror;
        }

        /**
         * 设置炉膛温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 104, Length = 1)]
        public void setLuTangWenDuError(int data)
        {
            lutangwenduerror = data;
        }

        //炉膛出口温度传感器故障
        public int lutangchukouwenduerror;

        /**
         * 获取炉膛出口温度传感器故障
         *
         * @return lutangchukouwendu
         */

        public int getLuTangChuKouWenDuError()
        {
            return lutangchukouwenduerror;
        }

        /**
         * 设置炉膛出口温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 105, Length = 1)]
        public void setLuTangChuKouWenDuError(int data)
        {
            lutangchukouwenduerror = data;
        }

        //炉壁温度传感器故障
        public int lubiwenduerror;

        /**
         * 获取炉壁温度传感器故障
         *
         * @return lubiwendu
         */

        public int getLuBiWenDuError()
        {
            return lubiwenduerror;
        }

        /**
         * 设置炉壁温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 106, Length = 1)]
        public void setLuBiWenDuError(int data)
        {
            lubiwenduerror = data;
        }

        //燃料温度传感器故障
        public int ranliaowenduerror;

        /**
         * 获取燃料温度传感器故障
         *
         * @return ranliaowendu
         */

        public int getRanLiaoWenDuError()
        {
            return ranliaowenduerror;
        }

        /**
         * 设置燃料温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 107, Length = 1)]
        public void setRanLiaoWenDuError(int data)
        {
            ranliaowenduerror = data;
        }

        //空预器出口热风温度传感器故障
        public int kongyuqichukourefengwenduerror;

        /**
         * 获取空预器出口热风温度传感器故障
         *
         * @return kongyuqichukourefengwendu
         */

        public int getKongYuQiChuKouReFengWenDuError()
        {
            return kongyuqichukourefengwenduerror;
        }

        /**
         * 设置空预器出口热风温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 108, Length = 1)]
        public void setKongYuQiChuKouReFengWenDuError(int data)
        {
            kongyuqichukourefengwenduerror = data;
        }

        //负压蒸汽温度传感器故障
        public int fuyazhengqiwenduerror;

        /**
         * 获取负压蒸汽温度传感器故障
         *
         * @return fuyazhengqiwendu
         */

        public int getFuYaZhengQiWenDuError()
        {
            return fuyazhengqiwenduerror;
        }

        /**
         * 设置负压蒸汽温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 109, Length = 1)]
        public void setFuYaZhengQiWenDuError(int data)
        {
            fuyazhengqiwenduerror = data;
        }

        //过热蒸汽温度传感器故障
        public int guorezhengqiwenduerror;

        /**
         * 获取过热蒸汽温度传感器故障
         *
         * @return guorezhengqiwendu
         */

        public int getGuoReZhengQiWenDuError()
        {
            return guorezhengqiwenduerror;
        }

        /**
         * 设置过热蒸汽温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 110, Length = 1)]
        public void setGuoReZhengQiWenDuError(int data)
        {
            guorezhengqiwenduerror = data;
        }

        //回路1温度传感器故障
        public int huilu1wenduerror;

        /**
         * 获取回路1温度传感器故障
         *
         * @return huilu1wendu
         */

        public int getHuiLu1WenDuError()
        {
            return huilu1wenduerror;
        }

        /**
         * 设置回路1温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 111, Length = 1)]
        public void setHuiLu1WenDuError(int data)
        {
            huilu1wenduerror = data;
        }

        //回路2温度传感器故障
        public int huilu2wenduerror;

        /**
         * 获取回路2温度传感器故障
         *
         * @return huilu2wendu
         */

        public int getHuiLu2WenDuError()
        {
            return huilu2wenduerror;
        }

        /**
         * 设置回路2温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 112, Length = 1)]
        public void setHuiLu2WenDuError(int data)
        {
            huilu2wenduerror = data;
        }

        //回路3温度传感器故障
        public int huilu3wenduerror;

        /**
         * 获取回路3温度传感器故障
         *
         * @return huilu3wendu
         */

        public int getHuiLu3WenDuError()
        {
            return huilu3wenduerror;
        }

        /**
         * 设置回路3温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 113, Length = 1)]
        public void setHuiLu3WenDuError(int data)
        {
            huilu3wenduerror = data;
        }

        //回路4温度传感器故障
        public int huilu4wenduerror;

        /**
         * 获取回路4温度传感器故障
         *
         * @return huilu4wendu
         */

        public int getHuiLu4WenDuError()
        {
            return huilu4wenduerror;
        }

        /**
         * 设置回路4温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 114, Length = 1)]
        public void setHuiLu4WenDuError(int data)
        {
            huilu4wenduerror = data;
        }

        //回路5温度传感器故障
        public int huilu5wenduerror;

        /**
         * 获取回路5温度传感器故障
         *
         * @return huilu5wendu
         */

        public int getHuiLu5WenDuError()
        {
            return huilu5wenduerror;
        }

        /**
         * 设置回路5温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 115, Length = 1)]
        public void setHuiLu5WenDuError(int data)
        {
            huilu5wenduerror = data;
        }

        //室外温度传感器故障
        public int shiwaiwenduerror;

        /**
         * 获取室外温度传感器故障
         *
         * @return shiwaiwendu
         */

        public int getShiWaiWenDuError()
        {
            return shiwaiwenduerror;
        }

        /**
         * 设置室外温度传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 116, Length = 1)]
        public void setShiWaiWenDuError(int data)
        {
            shiwaiwenduerror = data;
        }

        //蒸汽压力传感器故障
        public int zhengqiyalierror;

        /**
         * 获取蒸汽压力传感器故障
         *
         * @return zhengqiyali
         */

        public int getZhengQiYaLiError()
        {
            return zhengqiyalierror;
        }

        /**
         * 设置蒸汽压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 117, Length = 1)]
        public void setZhengQiYaLiError(int data)
        {
            zhengqiyalierror = data;
        }

        //给水压力传感器故障
        public int jishuiyalierror;

        /**
         * 获取给水压力传感器故障
         *
         * @return jishuiyali
         */

        public int getJiShuiYaLiError()
        {
            return jishuiyalierror;
        }

        /**
         * 设置给水压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 118, Length = 1)]
        public void setJiShuiYaLiError(int data)
        {
            jishuiyalierror = data;
        }

        //出口压力传感器故障
        public int chukouyalierror;

        /**
         * 获取出口压力传感器故障
         *
         * @return chukouyali
         */

        public int getChuKouYaLiError()
        {
            return chukouyalierror;
        }

        /**
         * 设置出口压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 119, Length = 1)]
        public void setChuKouYaLiError(int data)
        {
            chukouyalierror = data;
        }

        //入口压力传感器故障
        public int rukouyalierror;

        /**
         * 获取入口压力传感器故障
         *
         * @return rukouyali
         */

        public int getRuKouYaLiError()
        {
            return rukouyalierror;
        }

        /**
         * 设置入口压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 120, Length = 1)]
        public void setRuKouYaLiError(int data)
        {
            rukouyalierror = data;
        }

        //炉膛压力传感器故障
        public int lutangyalierror;

        /**
         * 获取炉膛压力传感器故障
         *
         * @return lutangyali
         */

        public int getLuTangYaLiError()
        {
            return lutangyalierror;
        }

        /**
         * 设置炉膛压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 121, Length = 1)]
        public void setLuTangYaLiError(int data)
        {
            lutangyalierror = data;
        }

        //炉膛出口压力传感器故障
        public int lutangchukouyalierror;

        /**
         * 获取炉膛出口压力传感器故障
         *
         * @return lutangchukouyali
         */

        public int getLuTangChuKouYaLiError()
        {
            return lutangchukouyalierror;
        }

        /**
         * 设置炉膛出口压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 122, Length = 1)]
        public void setLuTangChuKouYaLiError(int data)
        {
            lutangchukouyalierror = data;
        }

        //燃气压力传感器故障
        public int ranqiyalierror;

        /**
         * 获取燃气压力传感器故障
         *
         * @return ranqiyali
         */

        public int getRanQiYaLiError()
        {
            return ranqiyalierror;
        }

        /**
         * 设置燃气压力传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 123, Length = 1)]
        public void setRanQiYaLiError(int data)
        {
            ranqiyalierror = data;
        }

        //一次风压传感器故障
        public int yicifengyaerror;

        /**
         * 获取一次风压传感器故障
         *
         * @return yicifengya
         */

        public int getYiCiFengYaError()
        {
            return yicifengyaerror;
        }

        /**
         * 设置一次风压传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 124, Length = 1)]
        public void setYiCiFengYaError(int data)
        {
            yicifengyaerror = data;
        }

        //二次风压传感器故障
        public int ecifengyaerror;

        /**
         * 获取二次风压传感器故障
         *
         * @return ecifengya
         */

        public int getECiFengYaError()
        {
            return ecifengyaerror;
        }

        /**
         * 设置二次风压传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 125, Length = 1)]
        public void setECiFengYaError(int data)
        {
            ecifengyaerror = data;
        }

        //瞬时燃料量传感器故障
        public int shunshiranliaoliangerror;

        /**
         * 获取瞬时燃料量传感器故障
         *
         * @return shunshiranliaoliang
         */
        public int getShunShiRanLiaoLiangError()
        {
            return shunshiranliaoliangerror;
        }

        /**
         * 设置瞬时燃料量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 126, Length = 1)]
        public void setShunShiRanLiaoLiangError(int data)
        {
            shunshiranliaoliangerror = data;
        }

        //瞬时蒸汽流量传感器故障
        public int shunshizhengqiliuliangerror;

        /**
         * 获取瞬时蒸汽流量传感器故障
         *
         * @return shunshizhengqiliuliang
         */
        public int getShunShiZhengQiLiuLiangError()
        {
            return shunshizhengqiliuliangerror;
        }

        /**
         * 设置瞬时蒸汽流量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 127, Length = 1)]
        public void setShunShiZhengQiLiuLiangError(int data)
        {
            shunshizhengqiliuliangerror = data;
        }

        //瞬时给水流量传感器故障
        public int shunshijishuiliuliangerror;

        /**
         * 获取瞬时给水流量传感器故障
         *
         * @return shunshijishuiliuliang
         */
        public int getShunShiJiShuiLiuLiangError()
        {
            return shunshijishuiliuliangerror;
        }

        /**
         * 设置瞬时给水流量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 128, Length = 1)]
        public void setShunShiJiShuiLiuLiangError(int data)
        {
            shunshijishuiliuliangerror = data;
        }

        //瞬时循环流量传感器故障
        public int shunshixunhuanliuliangerror;

        /**
         * 获取瞬时循环流量传感器故障
         *
         * @return shunshixunhuanliuliang
         */
        public int getShunShiXunHuanLiuLiangError()
        {
            return shunshixunhuanliuliangerror;
        }

        /**
         * 设置瞬时循环流量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 129, Length = 1)]
        public void setShunShiXunHuanLiuLiangError(int data)
        {
            shunshixunhuanliuliangerror = data;
        }

        //瞬时补水流量传感器故障
        public int shunshibushuiliuliangerror;

        /**
         * 获取瞬时补水流量传感器故障
         *
         * @return shunshibushuiliuliang
         */
        public int getShunShiBuShuiLiuLiangError()
        {
            return shunshibushuiliuliangerror;
        }

        /**
         * 设置瞬时补水流量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 130, Length = 1)]
        public void setShunShiBuShuiLiuLiangError(int data)
        {
            shunshibushuiliuliangerror = data;
        }

        //锅炉液位传感器故障
        public int guoluyeweierror;

        /**
         * 获取锅炉液位传感器故障
         *
         * @return guoluyewei
         */
        public int getGuoLuYeWeiError()
        {
            return guoluyeweierror;
        }

        /**
         * 设置锅炉液位传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 131, Length = 1)]
        public void setGuoLuYeWeiError(int data)
        {
            guoluyeweierror = data;
        }

        //水箱液位传感器故障
        public int shuixiangyeweierror;

        /**
         * 获取水箱液位传感器故障
         *
         * @return shuixiangyewei
         */
        public int getShuiXiangYeWeiError()
        {
            return shuixiangyeweierror;
        }

        /**
         * 设置水箱液位传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 132, Length = 1)]
        public void setShuiXiangYeWeiError(int data)
        {
            shuixiangyeweierror = data;
        }

        //排烟氧含量传感器故障
        public int paiyanyanghanliangerror;

        /**
         * 获取排烟氧含量传感器故障
         *
         * @return paiyanyanghanliang
         */
        public int getPaiYanYangHanLiangError()
        {
            return paiyanyanghanliangerror;
        }

        /**
         * 设置排烟氧含量传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 133, Length = 1)]
        public void setPaiYanYangHanLiangError(int data)
        {
            paiyanyanghanliangerror = data;
        }

        //炉排速度反馈传感器故障
        public int lupaisudufankuierror;

        /**
         * 获取炉排速度反馈传感器故障
         *
         * @return lupaisudufankui
         */
        public int getLuPaiSuDuFanKuiError()
        {
            return lupaisudufankuierror;
        }

        /**
         * 设置炉排速度反馈传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 134, Length = 1)]
        public void setLuPaiSuDuFanKuiError(int data)
        {
            lupaisudufankuierror = data;
        }

        //引风输出反馈传感器故障
        public int yinfengshuchufankuierror;

        /**
         * 获取引风输出反馈传感器故障
         *
         * @return yinfengshuchufankui
         */
        public int getYinFengShuChuFanKuiError()
        {
            return yinfengshuchufankuierror;
        }

        /**
         * 设置引风输出反馈传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 135, Length = 1)]
        public void setYinFengShuChuFanKuiError(int data)
        {
            yinfengshuchufankuierror = data;
        }

        //鼓风输出反馈传感器故障
        public int gufengshuchufankuierror;

        /**
         * 获取鼓风输出反馈传感器故障
         *
         * @return gufengshuchufankui
         */
        public int getGuFengShuChuFanKuiError()
        {
            return gufengshuchufankuierror;
        }

        /**
         * 设置鼓风输出反馈传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 136, Length = 1)]
        public void setGuFengShuChuFanKuiError(int data)
        {
            gufengshuchufankuierror = data;
        }

        //给水输出反馈传感器故障
        public int jishuishuchufankuierror;

        /**
         * 获取给水输出反馈传感器故障
         *
         * @return jishuishuchufankui
         */
        public int getJiShuiShuChuFanKuiError()
        {
            return jishuishuchufankuierror;
        }

        /**
         * 设置给水输出反馈传感器故障
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 137, Length = 1)]
        public void setJiShuiShuChuFanKuiError(int data)
        {
            jishuishuchufankuierror = data;
        }

        #endregion
        #region ----------设备开关量属性(运行状态)----------
        //极限低水位报警电极（缺水保护）
        public int jixiandishuiweibaojingdianji;

        /**
         * 获取极限低水位报警电极（缺水保护）
         *
         * @return jixiandishuiweibaojingdianji
         */
        public int getJiXianDiShuiWeiBaoJingDianJi()

        {
            return jixiandishuiweibaojingdianji;
        }

        /**
         * 设置极限低水位报警电极（缺水保护）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 160, Length = 1)]
        public void setJiXianDiShuiWeiBaoJingDianJi(
                int data)

        {
            jixiandishuiweibaojingdianji = data;
        }

        //低水位报警电极
        public int dishuiweibaojingdianji;

        /**
         * 获取低水位报警电极
         *
         * @return dishuiweibaojingdianji
         */
        public int getDiShuiWeiBaoJingDianJi()
        {
            return dishuiweibaojingdianji;
        }

        /**
         * 设置低水位报警电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 161, Length = 1)]
        public void setDiShuiWeiBaoJingDianJi(int data)
        {
            dishuiweibaojingdianji = data;
        }

        //低水位电极
        public int dishuiweidianji;

        /**
         * 获取低水位电极
         *
         * @return dishuiweidianji
         */
        public int getDiShuiWeiDianJi()
        {
            return dishuiweidianji;
        }

        /**
         * 设置低水位电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 162, Length = 1)]
        public void setDiShuiWeiDianJi(int data)
        {
            dishuiweidianji = data;
        }

        //中水位电极
        public int zhongshuiweidianji;

        /**
         * 获取中水位电极
         *
         * @return zhongshuiweidianji
         */
        public int getZhongShuiWeiDianJi()
        {
            return zhongshuiweidianji;
        }

        /**
         * 设置中水位电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 163, Length = 1)]
        public void setZhongShuiWeiDianJi(int data)
        {
            zhongshuiweidianji = data;
        }

        //高水位电极
        public int gaoshuiweidianji;

        /**
         * 获取高水位电极
         *
         * @return gaoshuiweidianji
         */
        public int getGaoShuiWeiDianJi()
        {
            return gaoshuiweidianji;
        }

        /**
         * 设置高水位电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 164, Length = 1)]
        public void setGaoShuiWeiDianJi(int data)
        {
            gaoshuiweidianji = data;
        }

        //高水位报警电极
        public int gaoshuiweibaojingdianji;

        /**
         * 获取高水位报警电极
         *
         * @return gaoshuiweibaojingdianji
         */
        public int getGaoShuiWeiBaoJingDianJi()
        {
            return gaoshuiweibaojingdianji;
        }

        /**
         * 设置高水位报警电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 165, Length = 1)]
        public void setGaoShuiWeiBaoJingDianJi(int data)
        {
            gaoshuiweibaojingdianji = data;
        }

        //水箱低位电极
        public int shuixiangdiweidianji;

        /**
         * 获取水箱低位电极
         *
         * @return shuixiangdiweidianji
         */
        public int getShuiXiangDiWeiDianJi()
        {
            return shuixiangdiweidianji;
        }

        /**
         * 设置水箱低位电极
         *
         */
        [Attributes.Byte(StartIndex = 166, Length = 1)]
        public void setShuiXiangDiWeiDianJi(int data)
        {
            shuixiangdiweidianji = data;
        }

        //水箱高位电极
        public int shuixianggaoweidianji;

        /**
         * 获取水箱高位电极
         *
         * @return shuixianggaoweidianji
         */
        public int getShuiXiangGaoWeiDianJi()
        {
            return shuixianggaoweidianji;
        }

        /**
         * 设置水箱高位电极
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 167, Length = 1)]
        public void setShuiXiangGaoWeiDianJi(int data)
        {
            shuixianggaoweidianji = data;
        }

        //极限低液位报警信号（干接点）
        public int jixiandiyeweibaojingxinhao;

        /**
         * 获取极限低液位报警信号（干接点）
         *
         * @return jixiandiyeweibaojingxinhao
         */
        public int getJiXianDiYeWeiBaoJingXinHao()

        {
            return jixiandiyeweibaojingxinhao;
        }

        /**
         * 设置极限低液位报警信号（干接点）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 168, Length = 1)]
        public void setJiXianDiYeWeiBaoJingXinHao(
                int data)

        {
            jixiandiyeweibaojingxinhao = data;
        }

        //低报警信号（干接点）
        public int dibaojingxinhao;

        /**
         * 获取低报警信号（干接点）
         *
         * @return dibaojingxinhao
         */
        public int getDiBaoJingXinHao()

        {
            return dibaojingxinhao;
        }

        /**
         * 设置低报警信号（干接点）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 169, Length = 1)]
        public void setDiBaoJingXinHao(
                int data)

        {
            dibaojingxinhao = data;
        }

        //控泵信号（干接点）
        public int kongbengxinhao;

        /**
         * 获取控泵信号（干接点）
         *
         * @return kongbengxinhao
         */
        public int getKongBengXinHao()

        {
            return kongbengxinhao;
        }

        /**
         * 设置控泵信号（干接点）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 170, Length = 1)]
        public void setKongBengXinHao(
                int data)

        {
            kongbengxinhao = data;
        }

        //高报警信号（干接点）
        public int gaobaojingxinhao;

        /**
         * 获取高报警信号（干接点）
         *
         * @return gaobaojingxinhao
         */
        public int getGaoBaoJingXinHao()

        {
            return gaobaojingxinhao;
        }

        /**
         * 设置高报警信号（干接点）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 171, Length = 1)]
        public void setGaoBaoJingXinHao(int data)

        {
            gaobaojingxinhao = data;
        }

        //超压报警信号
        public int chaoyabaojingxinhao;

        /**
         * 获取超压报警信号
         *
         * @return chaoyabaojingxinhao
         */
        public int getChaoYaBaoJingXinHao()
        {
            return chaoyabaojingxinhao;
        }

        /**
         * 设置超压报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 172, Length = 1)]
        public void setChaoYaBaoJingXinHao(int data)
        {
            chaoyabaojingxinhao = data;
        }

        //负荷调节压力信号
        public int fuhediaojieyalixinhao;

        /**
         * 获取负荷调节压力信号
         *
         * @return fuhediaojieyalixinhao
         */
        public int getFuHeDiaoJieYaLiXinHao()
        {
            return fuhediaojieyalixinhao;
        }

        /**
         * 设置负荷调节压力信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 173, Length = 1)]
        public void setFuHeDiaoJieYaLiXinHao(int data)
        {
            fuhediaojieyalixinhao = data;
        }

        //启停控制压力信号
        public int qitingkongzhiyalixinhao;

        /**
         * 获取启停控制压力信号
         *
         * @return qitingkongzhiyalixinhao
         */
        public int getQiTingKongZhiYaLiXinHao()
        {
            return qitingkongzhiyalixinhao;
        }

        /**
         * 设置启停控制压力信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 174, Length = 1)]
        public void setQiTingKongZhiYaLiXinHao(int data)
        {
            qitingkongzhiyalixinhao = data;
        }

        //压力表低针
        public int yalibiaodizhen;

        /**
         * 获取压力表低针
         *
         * @return yalibiaodizhen
         */
        public int getYaLiBiaoDiZhen()
        {
            return yalibiaodizhen;
        }

        /**
         * 设置压力表低针
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 175, Length = 1)]
        public void setYaLiBiaoDiZhen(int data)
        {
            yalibiaodizhen = data;
        }

        //压力表高针
        public int yalibiaogaozhen;

        /**
         * 获取压力表高针
         *
         * @return yalibiaogaozhen
         */
        public int getYaLiBiaoGaoZhen()
        {
            return yalibiaogaozhen;
        }

        /**
         * 设置压力表高针
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 176, Length = 1)]
        public void setYaLiBiaoGaoZhen(int data)
        {
            yalibiaogaozhen = data;
        }

        //炉壁超温信号
        public int lubichaowenxinhao;

        /**
         * 获取炉壁超温信号
         *
         * @return lubichaowenxinhao
         */
        public int getLuBiChaoWenXinHao()
        {
            return lubichaowenxinhao;
        }

        /**
         * 设置炉壁超温信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 177, Length = 1)]
        public void setLuBiChaoWenXinHao(int data)
        {
            lubichaowenxinhao = data;
        }

        //燃烧器故障报警信号
        public int ranshaoqiguzhangbaojingxinhao;

        /**
         * 获取燃烧器故障报警信号
         *
         * @return ranshaoqiguzhangbaojingxinhao
         */
        public int getRanShaoQiGuZhangBaoJingXinHao()
        {
            return ranshaoqiguzhangbaojingxinhao;
        }

        /**
         * 设置燃烧器故障报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 178, Length = 1)]
        public void setRanShaoQiGuZhangBaoJingXinHao(int data)
        {
            ranshaoqiguzhangbaojingxinhao = data;
        }

        //燃气泄漏报警信号
        public int ranqixieloubaojingxinhao;

        /**
         * 获取燃气泄漏报警信号
         *
         * @return ranqixieloubaojingxinhao
         */
        public int getRanQiXieLouBaoJingXinHao()
        {
            return ranqixieloubaojingxinhao;
        }

        /**
         * 设置燃气泄漏报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 179, Length = 1)]
        public void setRanQiXieLouBaoJingXinHao(int data)
        {
            ranqixieloubaojingxinhao = data;
        }

        //燃气压力低报警信号
        public int ranqiyalidibaojingxinhao;

        /**
         * 获取燃气压力低报警信号
         *
         * @return ranqiyalidibaojingxinhao
         */
        public int getRanQiYaLiDiBaoJingXinHao()
        {
            return ranqiyalidibaojingxinhao;
        }

        /**
         * 设置燃气压力低报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 180, Length = 1)]
        public void setRanQiYaLiDiBaoJingXinHao(int data)
        {
            ranqiyalidibaojingxinhao = data;
        }

        //燃气压力异常报警信号
        public int ranqiyaliyichangbaojingxinhao;

        /**
         * 获取燃气压力异常报警信号
         *
         * @return ranqiyaliyichangbaojingxinhao
         */
        public int getRanQiYaLiYiChangBaoJingXinHao()
        {
            return ranqiyaliyichangbaojingxinhao;
        }

        /**
         * 设置燃气压力异常报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 181, Length = 1)]
        public void setRanQiYaLiYiChangBaoJingXinHao(int data)
        {
            ranqiyaliyichangbaojingxinhao = data;
        }

        //燃气压力高报警信号
        public int ranqiyaligaobaojingxinhao;

        /**
         * 获取燃气压力高报警信号
         *
         * @return ranqiyaligaobaojingxinhao
         */
        public int getRanQiYaLiGaoBaoJingXinHao()
        {
            return ranqiyaligaobaojingxinhao;
        }

        /**
         * 设置燃气压力高报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 182, Length = 1)]
        public void setRanQiYaLiGaoBaoJingXinHao(int data)
        {
            ranqiyaligaobaojingxinhao = data;
        }

        //循环泵动作反馈信号（主）
        public int xunhuanbengdongzuofankuixinhao;

        /**
         * 获取循环泵动作反馈信号（主）
         *
         * @return xunhuanbengdongzuofankuixinhao
         */
        public int getXunHuanBengDongZuoFanKuiXinHao()

        {
            return xunhuanbengdongzuofankuixinhao;
        }

        /**
         * 设置循环泵动作反馈信号（主）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 183, Length = 1)]
        public void setXunHuanBengDongZuoFanKuiXinHao(int data)

        {
            xunhuanbengdongzuofankuixinhao = data;
        }

        //循环泵动作反馈信号（备）
        public int xunhuanbengdongzuofankuixinhaobei;

        /**
         * 获取循环泵动作反馈信号（备）
         *
         * @return xunhuanbengdongzuofankuixinhaobei
         */
        public int getXunHuanBengDongZuoFanKuiXinHaoBei()

        {
            return xunhuanbengdongzuofankuixinhaobei;
        }

        /**
         * 设置循环泵动作反馈信号（备）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 184, Length = 1)]
        public void setXunHuanBengDongZuoFanKuiXinHaoBei(
                int data)

        {
            xunhuanbengdongzuofankuixinhaobei = data;
        }

        //给水泵动作反馈信号（主）
        public int jishuibengdongzuofankuixinhao;

        /**
         * 获取给水泵动作反馈信号（主）
         *
         * @return jishuibengdongzuofankuixinhao
         */
        public int getJiShuiBengDongZuoFanKuiXinHao()

        {
            return jishuibengdongzuofankuixinhao;
        }

        /**
         * 设置给水泵动作反馈信号（主）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 185, Length = 1)]
        public void setJiShuiBengDongZuoFanKuiXinHao(
                int data)

        {
            jishuibengdongzuofankuixinhao = data;
        }

        //给水泵动作反馈信号（备）
        public int jishuibengdongzuofankuixinhaobei;

        /**
         * 获取给水泵动作反馈信号（备）
         *
         * @return jishuibengdongzuofankuixinhaobei
         */
        public int getJiShuiBengDongZuoFanKuiXinHaoBei()

        {
            return jishuibengdongzuofankuixinhaobei;
        }

        /**
         * 设置给水泵动作反馈信号（备）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 186, Length = 1)]
        public void setJiShuiBengDongZuoFanKuiXinHaoBei(
                int data)

        {
            jishuibengdongzuofankuixinhaobei = data;
        }

        //引风机动作反馈信号
        public int yinfengjidongzuofankuixinhao;

        /**
         * 获取引风机动作反馈信号
         *
         * @return yinfengjidongzuofankuixinhao
         */
        public int getYinFengJiDongZuoFanKuiXinHao()
        {
            return yinfengjidongzuofankuixinhao;
        }

        /**
         * 设置引风机动作反馈信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 187, Length = 1)]
        public void setYinFengJiDongZuoFanKuiXinHao(int data)
        {
            yinfengjidongzuofankuixinhao = data;
        }

        //鼓风机动作反馈信号
        public int gufengjidongzuofankuixinhao;

        /**
         * 获取鼓风机动作反馈信号
         *
         * @return gufengjidongzuofankuixinhao
         */
        public int getGuFengJiDongZuoFanKuiXinHao()
        {
            return gufengjidongzuofankuixinhao;
        }

        /**
         * 设置鼓风机动作反馈信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 188, Length = 1)]
        public void setGuFengJiDongZuoFanKuiXinHao(int data)
        {
            gufengjidongzuofankuixinhao = data;
        }

        //二次鼓风机动作反馈信号
        public int ecigufengjidongzuofankuixinhao;

        /**
         * 获取二次鼓风机动作反馈信号
         *
         * @return ecigufengjidongzuofankuixinhao
         */
        public int getECiGuFengJiDongZuoFanKuiXinHao()
        {
            return ecigufengjidongzuofankuixinhao;
        }

        /**
         * 设置二次鼓风机动作反馈信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 189, Length = 1)]
        public void setECiGuFengJiDongZuoFanKuiXinHao(int data)
        {
            ecigufengjidongzuofankuixinhao = data;
        }

        //出渣机动作反馈信号
        public int chuzhajidongzuofankuixinhao;

        /**
         * 获取出渣机动作反馈信号
         *
         * @return chuzhajidongzuofankuixinhao
         */
        public int getChuZhaJiDongZuoFanKuiXinHao()
        {
            return chuzhajidongzuofankuixinhao;
        }

        /**
         * 设置出渣机动作反馈信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 190, Length = 1)]
        public void setChuZhaJiDongZuoFanKuiXinHao(int data)
        {
            chuzhajidongzuofankuixinhao = data;
        }

        //给水变频器故障信号
        public int jishuibianpinqiguzhangxinhao;

        /**
         * 获取给水变频器故障信号
         *
         * @return jishuibianpinqiguzhangxinhao
         */
        public int getJiShuiBianPinQiGuZhangXinHao()
        {
            return jishuibianpinqiguzhangxinhao;
        }

        /**
         * 设置给水变频器故障信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 191, Length = 1)]
        public void setJiShuiBianPinQiGuZhangXinHao(int data)
        {
            jishuibianpinqiguzhangxinhao = data;
        }

        //引风变频器故障信号
        public int yinfengbianpinqiguzhangxinhao;

        /**
         * 获取引风变频器故障信号
         *
         * @return yinfengbianpinqiguzhangxinhao
         */
        public int getYinFengBianPinQiGuZhangXinHao()
        {
            return yinfengbianpinqiguzhangxinhao;
        }

        /**
         * 设置引风变频器故障信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 192, Length = 1)]
        public void setYinFengBianPinQiGuZhangXinHao(int data)
        {
            yinfengbianpinqiguzhangxinhao = data;
        }

        //鼓风变频器故障信号
        public int gufengbianpinqiguzhangxinhao;

        /**
         * 获取鼓风变频器故障信号
         *
         * @return gufengbianpinqiguzhangxinhao
         */
        public int getGuFengBianPinQiGuZhangXinHao()
        {
            return gufengbianpinqiguzhangxinhao;
        }

        /**
         * 设置鼓风变频器故障信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 193, Length = 1)]
        public void setGuFengBianPinQiGuZhangXinHao(int data)
        {
            gufengbianpinqiguzhangxinhao = data;
        }

        //炉排变频器故障信号
        public int lupaibianpinqiguzhangxinhao;

        /**
         * 获取炉排变频器故障信号
         *
         * @return lupaibianpinqiguzhangxinhao
         */
        public int getLuPaiBianPinQiGuZhangXinHao()
        {
            return lupaibianpinqiguzhangxinhao;
        }

        /**
         * 设置炉排变频器故障信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 194, Length = 1)]
        public void setLuPaiBianPinQiGuZhangXinHao(int data)
        {
            lupaibianpinqiguzhangxinhao = data;
        }

        //烟道蝶阀反馈信号
        public int yandaodiefafankuixinhao;

        /**
         * 获取烟道蝶阀反馈信号
         *
         * @return yandaodiefafankuixinhao
         */
        public int getYanDaoDieFaFanKuiXinHao()
        {
            return yandaodiefafankuixinhao;
        }

        /**
         * 设置烟道蝶阀反馈信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 195, Length = 1)]
        public void setYanDaoDieFaFanKuiXinHao(int data)
        {
            yandaodiefafankuixinhao = data;
        }

        //低电压报警信号
        public int didianyabaojingxinhao;

        /**
         * 获取低电压报警信号
         *
         * @return didianyabaojingxinhao
         */
        public int getDiDianYaBaoJingXinHao()
        {
            return didianyabaojingxinhao;
        }

        /**
         * 设置低电压报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 196, Length = 1)]
        public void setDiDianYaBaoJingXinHao(int data)
        {
            didianyabaojingxinhao = data;
        }

        //高电压报警信号
        public int gaodianyabaojingxinhao;

        /**
         * 获取高电压报警信号
         *
         * @return gaodianyabaojingxinhao
         */
        public int getGaoDianYaBaoJingXinHao()
        {
            return gaodianyabaojingxinhao;
        }

        /**
         * 设置高电压报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 197, Length = 1)]
        public void setGaoDianYaBaoJingXinHao(int data)
        {
            gaodianyabaojingxinhao = data;
        }

        //缺相报警信号
        public int quexiangbaojingxinhao;

        /**
         * 获取缺相报警信号
         *
         * @return quexiangbaojingxinhao
         */
        public int getQueXiangBaoJingXinHao()
        {
            return quexiangbaojingxinhao;
        }

        /**
         * 设置缺相报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 198, Length = 1)]
        public void setQueXiangBaoJingXinHao(int data)
        {
            quexiangbaojingxinhao = data;
        }

        //漏电报警信号
        public int loudianbaojingxinhao;

        /**
         * 获取漏电报警信号
         *
         * @return loudianbaojingxinhao
         */
        public int getLouDianBaoJingXinHao()
        {
            return loudianbaojingxinhao;
        }

        /**
         * 设置漏电报警信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 199, Length = 1)]
        public void setLouDianBaoJingXinHao(int data)
        {
            loudianbaojingxinhao = data;
        }

        //缺水电极2
        public int queshuidianji2;

        /**
         * 获取缺水电极2
         *
         * @return queshuidianji2
         */
        public int getQueShuiDianJi2()
        {
            return queshuidianji2;
        }

        /**
         * 设置缺水电极2
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 200, Length = 1)]
        public void setQueShuiDianJi2(int data)
        {
            queshuidianji2 = data;
        }

        //外部连锁信号
        public int waibuliansuoxinhao;

        /**
         * 获取外部连锁信号
         *
         * @return waibuliansuoxinhao
         */
        public int getWaiBuLianSuoXinHao()
        {
            return waibuliansuoxinhao;
        }

        /**
         * 设置外部连锁信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 201, Length = 1)]
        public void setWaiBuLianSuoXinHao(int data)
        {
            waibuliansuoxinhao = data;
        }

        //超低压保护信号
        public int chaodiyabaohuxinhao;

        /**
         * 获取超低压保护信号
         *
         * @return chaodiyabaohuxinhao
         */
        public int getChaoDiYaBaoHuXinHao()
        {
            return chaodiyabaohuxinhao;
        }

        /**
         * 设置超低压保护信号
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 202, Length = 1)]
        public void setChaoDiYaBaoHuXinHao(int data)
        {
            chaodiyabaohuxinhao = data;
        }

        //燃烧器启停
        public int ranshaoqiqiting;

        /**
         * 获取燃烧器启停
         *
         * @return ranshaoqiqiting
         */
        public int getRanShaoQiQiTing()
        {
            return ranshaoqiqiting;
        }

        /**
         * 设置燃烧器启停
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 224, Length = 1)]
        public void setRanShaoQiQiTing(int data)
        {
            ranshaoqiqiting = data;
        }

        //燃烧器大火
        public int ranshaoqidahuo;

        /**
         * 获取燃烧器大火
         *
         * @return ranshaoqidahuo
         */
        public int getRanShaoQiDaHuo()
        {
            return ranshaoqidahuo;
        }

        /**
         * 设置燃烧器大火
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 225, Length = 1)]
        public void setRanShaoQiDaHuo(int data)
        {
            ranshaoqidahuo = data;
        }

        //燃烧器三段火
        public int ranshaoqisanduanhuo;

        /**
         * 获取燃烧器三段火
         *
         * @return ranshaoqisanduanhuo
         */
        public int getRanShaoQiSanDuanHuo()
        {
            return ranshaoqisanduanhuo;
        }

        /**
         * 设置燃烧器三段火
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 226, Length = 1)]
        public void setRanShaoQiSanDuanHuo(int data)
        {
            ranshaoqisanduanhuo = data;
        }

        //燃烧器火力增加
        public int ranshaoqihuolizengjia;

        /**
         * 获取燃烧器火力增加
         *
         * @return ranshaoqihuolizengjia
         */
        public int getRanShaoQiHuoLiZengJia()
        {
            return ranshaoqihuolizengjia;
        }

        /**
         * 设置燃烧器火力增加
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 227, Length = 1)]
        public void setRanShaoQiHuoLiZengJia(int data)
        {
            ranshaoqihuolizengjia = data;
        }

        //燃烧器火力减少
        public int ranshaoqihuolijianshao;

        /**
         * 获取燃烧器火力减少
         *
         * @return ranshaoqihuolijianshao
         */
        public int getRanShaoQiHuoLiJianShao()
        {
            return ranshaoqihuolijianshao;
        }

        /**
         * 设置燃烧器火力减少
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 228, Length = 1)]
        public void setRanShaoQiHuoLiJianShao(int data)
        {
            ranshaoqihuolijianshao = data;
        }

        //给水泵（主）
        public int jishuibeng;

        /**
         * 获取给水泵（主）
         *
         * @return jishuibeng
         */
        public int getJiShuiBengZhu()

        {
            return jishuibeng;
        }

        /**
         * 设置给水泵（主）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 229, Length = 1)]
        public void setJiShuiBeng(
                int data)

        {
            jishuibeng = data;
        }

        //给水泵（备）
        public int jishuibengbei;

        /**
         * 获取给水泵（备）
         *
         * @return jishuibengbei
         */
        public int getJiShuiBengBei()

        {
            return jishuibengbei;
        }

        /**
         * 设置给水泵（备）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 230, Length = 1)]
        public void setJiShuiBengBei(
                int data)

        {
            jishuibengbei = data;
        }

        //给水量增加
        public int jishuiliangzengjia;

        /**
         * 获取给水量增加
         *
         * @return jishuiliangzengjia
         */
        public int getJiShuiLiangZengJia()
        {
            return jishuiliangzengjia;
        }

        /**
         * 设置给水量增加
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 231, Length = 1)]
        public void setJiShuiLiangZengJia(int data)
        {
            jishuiliangzengjia = data;
        }

        //给水量减少
        public int jishuiliangjianshao;

        /**
         * 获取给水量减少
         *
         * @return jishuiliangjianshao
         */
        public int getJiShuiLiangJianShao()
        {
            return jishuiliangjianshao;
        }

        /**
         * 设置给水量减少
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 232, Length = 1)]
        public void setJiShuiLiangJianShao(int data)
        {
            jishuiliangjianshao = data;
        }

        //循环泵（主）
        public int xunhuanbeng;

        /**
         * 获取循环泵（主）
         *
         * @return xunhuanbeng
         */
        public int getXunHuanBeng()

        {
            return xunhuanbeng;
        }

        /**
         * 设置循环泵（主）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 233, Length = 1)]
        public void setXunHuanBeng(
                int data)

        {
            xunhuanbeng = data;
        }

        //循环泵（备）
        public int xunhuanbengbei;

        /**
         * 获取循环泵（备）
         *
         * @return xunhuanbengbei
         */
        public int getXunHuanBengBei()

        {
            return xunhuanbengbei;
        }

        /**
         * 设置循环泵（备）
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 234, Length = 1)]
        public void setXunHuanBengBei(
                int data)

        {
            xunhuanbengbei = data;
        }

        //报警输出
        public int baojingshuchu;

        /**
         * 获取报警输出
         *
         * @return baojingshuchu
         */
        public int getBaoJingShuChu()
        {
            return baojingshuchu;
        }

        /**
         * 设置报警输出
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 235, Length = 1)]
        public void setBaoJingShuChu(int data)
        {
            baojingshuchu = data;
        }

        //加热组1
        public int jiarezu1;

        /**
         * 获取加热组1
         *
         * @return jiarezu1
         */
        public int getJiaReZu1()
        {
            return jiarezu1;
        }

        /**
         * 设置加热组1
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 236, Length = 1)]
        public void setJiaReZu1(int data)
        {
            jiarezu1 = data;
        }

        //加热组2
        public int jiarezu2;

        /**
         * 获取加热组2
         *
         * @return jiarezu2
         */
        public int getJiaReZu2()
        {
            return jiarezu2;
        }

        /**
         * 设置加热组2
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 237, Length = 1)]
        public void setJiaReZu2(int data)
        {
            jiarezu2 = data;
        }

        //加热组3
        public int jiarezu3;

        /**
         * 获取加热组3
         *
         * @return jiarezu3
         */
        public int getJiaReZu3()
        {
            return jiarezu3;
        }

        /**
         * 设置加热组3
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 238, Length = 1)]
        public void setJiaReZu3(int data)
        {
            jiarezu3 = data;
        }

        //加热组4
        public int jiarezu4;

        /**
         * 获取加热组4
         *
         * @return jiarezu4
         */
        public int getJiaReZu4()
        {
            return jiarezu4;
        }

        /**
         * 设置加热组4
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 239, Length = 1)]
        public void setJiaReZu4(int data)
        {
            jiarezu4 = data;
        }

        //加热组5
        public int jiarezu5;

        /**
         * 获取加热组5
         *
         * @return jiarezu5
         */
        public int getJiaReZu5()
        {
            return jiarezu5;
        }

        /**
         * 设置加热组5
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 240, Length = 1)]
        public void setJiaReZu5(int data)
        {
            jiarezu5 = data;
        }

        //加热组6
        public int jiarezu6;

        /**
         * 获取加热组6
         *
         * @return jiarezu6
         */
        public int getJiaReZu6()
        {
            return jiarezu6;
        }

        /**
         * 设置加热组6
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 241, Length = 1)]
        public void setJiaReZu6(int data)
        {
            jiarezu6 = data;
        }

        //加热组7
        public int jiarezu7;

        /**
         * 获取加热组7
         *
         * @return jiarezu7
         */
        public int getJiaReZu7()
        {
            return jiarezu7;
        }

        /**
         * 设置加热组7
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 242, Length = 1)]
        public void setJiaReZu7(int data)
        {
            jiarezu7 = data;
        }

        //加热组8
        public int jiarezu8;

        /**
         * 获取加热组8
         *
         * @return jiarezu8
         */
        public int getJiaReZu8()
        {
            return jiarezu8;
        }

        /**
         * 设置加热组8
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 243, Length = 1)]
        public void setJiaReZu8(int data)
        {
            jiarezu8 = data;
        }

        //加热组9
        public int jiarezu9;

        /**
         * 获取加热组9
         *
         * @return jiarezu9
         */
        public int getJiaReZu9()
        {
            return jiarezu9;
        }

        /**
         * 设置加热组9
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 244, Length = 1)]
        public void setJiaReZu9(int data)
        {
            jiarezu9 = data;
        }

        //加热组10
        public int jiarezu10;

        /**
         * 获取加热组10
         *
         * @return jiarezu10
         */
        public int getJiaReZu10()
        {
            return jiarezu10;
        }

        /**
         * 设置加热组10
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 245, Length = 1)]
        public void setJiaReZu10(int data)
        {
            jiarezu10 = data;
        }

        //加热组11
        public int jiarezu11;

        /**
         * 获取加热组11
         *
         * @return jiarezu11
         */
        public int getJiaReZu11()
        {
            return jiarezu11;
        }

        /**
         * 设置加热组11
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 246, Length = 1)]
        public void setJiaReZu11(int data)
        {
            jiarezu11 = data;
        }

        //加热组12
        public int jiarezu12;

        /**
         * 获取加热组12
         *
         * @return jiarezu12
         */
        public int getJiaReZu12()
        {
            return jiarezu12;
        }

        /**
         * 设置加热组12
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 247, Length = 1)]
        public void setJiaReZu12(int data)
        {
            jiarezu12 = data;
        }

        //加热组13
        public int jiarezu13;

        /**
         * 获取加热组13
         *
         * @return jiarezu13
         */
        public int getJiaReZu13()
        {
            return jiarezu13;
        }

        /**
         * 设置加热组13
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 248, Length = 1)]
        public void setJiaReZu13(int data)
        {
            jiarezu13 = data;
        }

        //加热组14
        public int jiarezu14;

        /**
         * 获取加热组14
         *
         * @return jiarezu14
         */
        public int getJiaReZu14()
        {
            return jiarezu14;
        }

        /**
         * 设置加热组14
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 249, Length = 1)]
        public void setJiaReZu14(int data)
        {
            jiarezu14 = data;
        }

        //加热组15
        public int jiarezu15;

        /**
         * 获取加热组15
         *
         * @return jiarezu15
         */
        public int getJiaReZu15()
        {
            return jiarezu15;
        }

        /**
         * 设置加热组15
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 250, Length = 1)]
        public void setJiaReZu15(int data)
        {
            jiarezu15 = data;
        }

        //加热组16
        public int jiarezu16;

        /**
         * 获取加热组16
         *
         * @return jiarezu16
         */
        public int getJiaReZu16()
        {
            return jiarezu16;
        }

        /**
         * 设置加热组16
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 251, Length = 1)]
        public void setJiaReZu16(int data)
        {
            jiarezu16 = data;
        }

        //加热组17
        public int jiarezu17;

        /**
         * 获取加热组17
         *
         * @return jiarezu17
         */
        public int getJiaReZu17()
        {
            return jiarezu17;
        }

        /**
         * 设置加热组17
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 252, Length = 1)]
        public void setJiaReZu17(int data)
        {
            jiarezu17 = data;
        }

        //加热组18
        public int jiarezu18;

        /**
         * 获取加热组18
         *
         * @return jiarezu18
         */
        public int getJiaReZu18()
        {
            return jiarezu18;
        }

        /**
         * 设置加热组18
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 253, Length = 1)]
        public void setJiaReZu18(int data)
        {
            jiarezu18 = data;
        }

        //加热组19
        public int jiarezu19;

        /**
         * 获取加热组19
         *
         * @return jiarezu19
         */
        public int getJiaReZu19()
        {
            return jiarezu19;
        }

        /**
         * 设置加热组19
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 254, Length = 1)]
        public void setJiaReZu19(int data)
        {
            jiarezu19 = data;
        }

        //加热组20
        public int jiarezu20;

        /**
         * 获取加热组20
         *
         * @return jiarezu20
         */
        public int getJiaReZu20()
        {
            return jiarezu20;
        }

        /**
         * 设置加热组20
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 255, Length = 1)]
        public void setJiaReZu20(int data)
        {
            jiarezu20 = data;
        }

        //加热组21
        public int jiarezu21;

        /**
         * 获取加热组21
         *
         * @return jiarezu21
         */
        public int getJiaReZu21()
        {
            return jiarezu21;
        }

        /**
         * 设置加热组21
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 256, Length = 1)]
        public void setJiaReZu21(int data)
        {
            jiarezu21 = data;
        }

        //加热组22
        public int jiarezu22;

        /**
         * 获取加热组22
         *
         * @return jiarezu22
         */
        public int getJiaReZu22()
        {
            return jiarezu22;
        }

        /**
         * 设置加热组22
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 257, Length = 1)]
        public void setJiaReZu22(int data)
        {
            jiarezu22 = data;
        }

        //加热组23
        public int jiarezu23;

        /**
         * 获取加热组23
         *
         * @return jiarezu23
         */
        public int getJiaReZu23()
        {
            return jiarezu23;
        }

        /**
         * 设置加热组23
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 258, Length = 1)]
        public void setJiaReZu23(int data)
        {
            jiarezu23 = data;
        }

        //加热组24
        public int jiarezu24;

        /**
         * 获取加热组24
         *
         * @return jiarezu24
         */
        public int getJiaReZu24()
        {
            return jiarezu24;
        }

        /**
         * 设置加热组24
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 259, Length = 1)]
        public void setJiaReZu24(int data)
        {
            jiarezu24 = data;
        }

        //加热组25
        public int jiarezu25;

        /**
         * 获取加热组25
         *
         * @return jiarezu25
         */
        public int getJiaReZu25()
        {
            return jiarezu25;
        }

        /**
         * 设置加热组25
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 260, Length = 1)]
        public void setJiaReZu25(int data)
        {
            jiarezu25 = data;
        }

        //加热组26
        public int jiarezu26;

        /**
         * 获取加热组26
         *
         * @return jiarezu26
         */
        public int getJiaReZu26()
        {
            return jiarezu26;
        }

        /**
         * 设置加热组26
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 261, Length = 1)]
        public void setJiaReZu26(int data)
        {
            jiarezu26 = data;
        }

        //加热组27
        public int jiarezu27;

        /**
         * 获取加热组27
         *
         * @return jiarezu27
         */
        public int getJiaReZu27()
        {
            return jiarezu27;
        }

        /**
         * 设置加热组27
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 262, Length = 1)]
        public void setJiaReZu27(int data)
        {
            jiarezu27 = data;
        }

        //加热组28
        public int jiarezu28;

        /**
         * 获取加热组28
         *
         * @return jiarezu28
         */
        public int getJiaReZu28()
        {
            return jiarezu28;
        }

        /**
         * 设置加热组28
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 263, Length = 1)]
        public void setJiaReZu28(int data)
        {
            jiarezu28 = data;
        }

        //加热组29
        public int jiarezu29;

        /**
         * 获取加热组29
         *
         * @return jiarezu29
         */
        public int getJiaReZu29()
        {
            return jiarezu29;
        }

        /**
         * 设置加热组29
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 264, Length = 1)]
        public void setJiaReZu29(int data)
        {
            jiarezu29 = data;
        }

        //加热组30
        public int jiarezu30;

        /**
         * 获取加热组30
         *
         * @return jiarezu30
         */
        public int getJiaReZu30()
        {
            return jiarezu30;
        }

        /**
         * 设置加热组30
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 265, Length = 1)]
        public void setJiaReZu30(int data)
        {
            jiarezu30 = data;
        }

        //引风机
        public int yinfengji;

        /**
         * 获取引风机
         *
         * @return yinfengji
         */
        public int getYinFengJi()
        {
            return yinfengji;
        }

        /**
         * 设置引风机
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 266, Length = 1)]
        public void setYinFengJi(int data)
        {
            yinfengji = data;
        }

        //引风量增加
        public int yinfengliangzengjia;

        /**
         * 获取引风量增加
         *
         * @return yinfengliangzengjia
         */
        public int getYinFengLiangZengJia()
        {
            return yinfengliangzengjia;
        }

        /**
         * 设置引风量增加
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 267, Length = 1)]
        public void setYinFengLiangZengJia(int data)
        {
            yinfengliangzengjia = data;
        }

        //引风量减少
        public int yinfengliangjianshao;

        /**
         * 获取引风量减少
         *
         * @return yinfengliangjianshao
         */
        public int getYinFengLiangJianShao()
        {
            return yinfengliangjianshao;
        }

        /**
         * 设置引风量减少
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 268, Length = 1)]
        public void setYinFengLiangJianShao(int data)
        {
            yinfengliangjianshao = data;
        }

        //鼓风机
        public int gufengji;

        /**
         * 获取鼓风机
         *
         * @return gufengji
         */
        public int getGuFengJi()
        {
            return gufengji;
        }

        /**
         * 设置鼓风机
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 269, Length = 1)]
        public void setGuFengJi(int data)
        {
            gufengji = data;
        }

        //鼓风量增加
        public int gufengliangzengjia;

        /**
         * 获取鼓风量增加
         *
         * @return gufengliangzengjia
         */
        public int getGuFengLiangZengJia()
        {
            return gufengliangzengjia;
        }

        /**
         * 设置鼓风量增加
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 270, Length = 1)]
        public void setGuFengLiangZengJia(int data)
        {
            gufengliangzengjia = data;
        }

        //鼓风量减少
        public int gufengliangjianshao;

        /**
         * 获取鼓风量减少
         *
         * @return gufengliangjianshao
         */
        public int getGuFengLiangJianShao()
        {
            return gufengliangjianshao;
        }

        /**
         * 设置鼓风量减少
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 271, Length = 1)]
        public void setGuFengLiangJianShao(int data)
        {
            gufengliangjianshao = data;
        }

        //二次鼓风机
        public int ecigufengji;

        /**
         * 获取二次鼓风机
         *
         * @return ecigufengji
         */
        public int getECiGuFengJi()
        {
            return ecigufengji;
        }

        /**
         * 设置二次鼓风机
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 272, Length = 1)]
        public void setECiGuFengJi(int data)
        {
            ecigufengji = data;
        }

        //二次鼓风量增加
        public int ecigufengliangzengjia;

        /**
         * 获取二次鼓风量增加
         *
         * @return ecigufengliangzengjia
         */
        public int getECiGuFengLiangZengJia()
        {
            return ecigufengliangzengjia;
        }

        /**
         * 设置二次鼓风量增加
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 273, Length = 1)]
        public void setECiGuFengLiangZengJia(int data)
        {
            ecigufengliangzengjia = data;
        }

        //二次鼓风量减少
        public int ecigufengliangjianshao;

        /**
         * 获取二次鼓风量减少
         *
         * @return ecigufengliangjianshao
         */
        public int getECiGuFengLiangJianShao()
        {
            return ecigufengliangjianshao;
        }

        /**
         * 设置二次鼓风量减少
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 274, Length = 1)]
        public void setECiGuFengLiangJianShao(int data)
        {
            ecigufengliangjianshao = data;
        }

        //炉排或进料机正转
        public int lupaihuojinliaojizhengzhuan;

        /**
         * 获取炉排或进料机正转
         *
         * @return lupaihuojinliaojizhengzhuan
         */
        public int getLuPaiHuoJinLiaoJiZhengZhuan()
        {
            return lupaihuojinliaojizhengzhuan;
        }

        /**
         * 设置炉排或进料机正转
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 275, Length = 1)]
        public void setLuPaiHuoJinLiaoJiZhengZhuan(int data)
        {
            lupaihuojinliaojizhengzhuan = data;
        }

        //炉排反转
        public int lupaifanzhuan;

        /**
         * 获取炉排反转
         *
         * @return lupaifanzhuan
         */
        public int getLuPaiFanZhuan()
        {
            return lupaifanzhuan;
        }

        /**
         * 设置炉排反转
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 276, Length = 1)]
        public void setLuPaiFanZhuan(int data)
        {
            lupaifanzhuan = data;
        }

        //出渣机
        public int chuzhaji;

        /**
         * 获取出渣机
         *
         * @return chuzhaji
         */
        public int getChuZhaJi()
        {
            return chuzhaji;
        }

        /**
         * 设置出渣机
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 277, Length = 1)]
        public void setChuZhaJi(int data)
        {
            chuzhaji = data;
        }

        //点火器
        public int dianhuoqi;

        /**
         * 获取点火器
         *
         * @return dianhuoqi
         */
        public int getDianHuoQi()
        {
            return dianhuoqi;
        }

        /**
         * 设置点火器
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 278, Length = 1)]
        public void setDianHuoQi(int data)
        {
            dianhuoqi = data;
        }

        //加药泵
        public int jiayaobeng;

        /**
         * 获取加药泵
         *
         * @return jiayaobeng
         */
        public int getJiaYaoBeng()
        {
            return jiayaobeng;
        }

        /**
         * 设置加药泵
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 279, Length = 1)]
        public void setJiaYaoBeng(int data)
        {
            jiayaobeng = data;
        }

        //排污阀
        public int paiwufa;

        /**
         * 获取排污阀
         *
         * @return paiwufa
         */
        public int getPaiWuFa()
        {
            return paiwufa;
        }

        /**
         * 设置排污阀
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 280, Length = 1)]
        public void setPaiWuFa(int data)
        {
            paiwufa = data;
        }
        #endregion
        #region ----------设备监控模拟量属性(运行状态)----------
        //本体排烟温度,单位："℃"
        public int bentipaiyanwendu;

        /**
         * 获取本体排烟温度
         *
         * @return bentipaiyanwendu
         */
        public int getBenTiPaiYanWenDu()
        {
            return bentipaiyanwendu;
        }

        /**
         * 设置本体排烟温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 288, Length = 2)]
        public void setBenTiPaiYanWenDu(int data)
        {
            bentipaiyanwendu = data;
        }

        //排烟温度,单位："℃"
        public int paiyanwendu;

        /**
         * 获取排烟温度
         *
         * @return paiyanwendu
         */
        public int getPaiYanWenDu()
        {
            return paiyanwendu;
        }

        /**
         * 设置排烟温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 290, Length = 2)]
        public void setPaiYanWenDu(int data)
        {
            paiyanwendu = data;
        }

        //炉水温度,单位："℃"
        public int lushuiwendu;

        /**
         * 获取炉水温度
         *
         * @return lushuiwendu
         */
        public int getLuShuiWenDu()
        {
            return lushuiwendu;
        }

        /**
         * 设置炉水温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 292, Length = 2)]
        public void setLuShuiWenDu(int data)
        {
            lushuiwendu = data;
        }

        //出口温度,单位："℃"
        public int chukouwendu;

        /**
         * 获取出口温度
         *
         * @return chukouwendu
         */
        public int getChuKouWenDu()
        {
            return chukouwendu;
        }

        /**
         * 设置出口温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 294, Length = 2)]
        public void setChuKouWenDu(int data)
        {
            chukouwendu = data;
        }

        //入口温度,单位："℃"
        public int rukouwendu;

        /**
         * 获取入口温度
         *
         * @return rukouwendu
         */
        public int getRuKouWenDu()
        {
            return rukouwendu;
        }

        /**
         * 设置入口温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 296, Length = 2)]
        public void setRuKouWenDu(int data)
        {
            rukouwendu = data;
        }

        //节能器出口温度,单位："℃"
        public int jienengqichukouwendu;

        /**
         * 获取节能器出口温度
         *
         * @return jienengqichukouwendu
         */
        public int getJieNengQiChuKouWenDu()
        {
            return jienengqichukouwendu;
        }

        /**
         * 设置节能器出口温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 298, Length = 2)]
        public void setJieNengQiChuKouWenDu(int data)
        {
            jienengqichukouwendu = data;
        }

        //节能器入口温度,单位："℃"
        public int jienengqirukouwendu;

        /**
         * 获取节能器入口温度
         *
         * @return jienengqirukouwendu
         */
        public int getJieNengQiRuKouWenDu()
        {
            return jienengqirukouwendu;
        }

        /**
         * 设置节能器入口温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 300, Length = 2)]
        public void setJieNengQiRuKouWenDu(int data)
        {
            jienengqirukouwendu = data;
        }

        //给水温度,单位："℃"
        public int jishuiwendu;

        /**
         * 获取给水温度
         *
         * @return jishuiwendu
         */
        public int getJiShuiWenDu()
        {
            return jishuiwendu;
        }

        /**
         * 设置给水温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 302, Length = 2)]
        public void setJiShuiWenDu(int data)
        {
            jishuiwendu = data;
        }

        //炉膛温度,单位："℃"
        public int lutangwendu;

        /**
         * 获取炉膛温度
         *
         * @return lutangwendu
         */
        public int getLuTangWenDu()
        {
            return lutangwendu;
        }

        /**
         * 设置炉膛温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 304, Length = 2)]
        public void setLuTangWenDu(int data)
        {
            lutangwendu = data;
        }

        //炉膛出口温度,单位："℃"
        public int lutangchukouwendu;

        /**
         * 获取炉膛出口温度
         *
         * @return lutangchukouwendu
         */
        public int getLuTangChuKouWenDu()
        {
            return lutangchukouwendu;
        }

        /**
         * 设置炉膛出口温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 306, Length = 2)]
        public void setLuTangChuKouWenDu(int data)
        {
            lutangchukouwendu = data;
        }

        //炉壁温度,单位："℃"
        public int lubiwendu;

        /**
         * 获取炉壁温度
         *
         * @return lubiwendu
         */
        public int getLuBiWenDu()
        {
            return lubiwendu;
        }

        /**
         * 设置炉壁温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 308, Length = 2)]
        public void setLuBiWenDu(int data)
        {
            lubiwendu = data;
        }

        //燃料温度,单位："℃"
        public int ranliaowendu;

        /**
         * 获取燃料温度
         *
         * @return ranliaowendu
         */
        public int getRanLiaoWenDu()
        {
            return ranliaowendu;
        }

        /**
         * 设置燃料温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 310, Length = 2)]
        public void setRanLiaoWenDu(int data)
        {
            ranliaowendu = data;
        }

        //空预器出口热风温度,单位："℃"
        public int kongyuqichukourefengwendu;

        /**
         * 获取空预器出口热风温度
         *
         * @return kongyuqichukourefengwendu
         */
        public int getKongYuQiChuKouReFengWenDu()
        {
            return kongyuqichukourefengwendu;
        }

        /**
         * 设置空预器出口热风温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 312, Length = 2)]
        public void setKongYuQiChuKouReFengWenDu(int data)
        {
            kongyuqichukourefengwendu = data;
        }

        //负压蒸汽温度,单位："℃"
        public int fuyazhengqiwendu;

        /**
         * 获取负压蒸汽温度
         *
         * @return fuyazhengqiwendu
         */
        public int getFuYaZhengQiWenDu()
        {
            return fuyazhengqiwendu;
        }

        /**
         * 设置负压蒸汽温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 314, Length = 2)]
        public void setFuYaZhengQiWenDu(int data)
        {
            fuyazhengqiwendu = data;
        }

        //过热蒸汽温度,单位："℃"
        public int guorezhengqiwendu;

        /**
         * 获取过热蒸汽温度
         *
         * @return guorezhengqiwendu
         */
        public int getGuoReZhengQiWenDu()
        {
            return guorezhengqiwendu;
        }

        /**
         * 设置过热蒸汽温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 316, Length = 2)]
        public void setGuoReZhengQiWenDu(int data)
        {
            guorezhengqiwendu = data;
        }

        //回路1温度,单位："℃"
        public int huilu1wendu;

        /**
         * 获取回路1温度
         *
         * @return huilu1wendu
         */
        public int getHuiLu1WenDu()
        {
            return huilu1wendu;
        }

        /**
         * 设置回路1温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 318, Length = 2)]
        public void setHuiLu1WenDu(int data)
        {
            huilu1wendu = data;
        }

        //回路2温度,单位："℃"
        public int huilu2wendu;

        /**
         * 获取回路2温度
         *
         * @return huilu2wendu
         */
        public int getHuiLu2WenDu()
        {
            return huilu2wendu;
        }

        /**
         * 设置回路2温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 320, Length = 2)]
        public void setHuiLu2WenDu(int data)
        {
            huilu2wendu = data;
        }

        //回路3温度,单位："℃"
        public int huilu3wendu;

        /**
         * 获取回路3温度
         *
         * @return huilu3wendu
         */
        public int getHuiLu3WenDu()
        {
            return huilu3wendu;
        }

        /**
         * 设置回路3温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 322, Length = 2)]
        public void setHuiLu3WenDu(int data)
        {
            huilu3wendu = data;
        }

        //回路4温度,单位："℃"
        public int huilu4wendu;

        /**
         * 获取回路4温度
         *
         * @return huilu4wendu
         */
        public int getHuiLu4WenDu()
        {
            return huilu4wendu;
        }

        /**
         * 设置回路4温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 324, Length = 2)]
        public void setHuiLu4WenDu(int data)
        {
            huilu4wendu = data;
        }

        //回路5温度,单位："℃"
        public int huilu5wendu;

        /**
         * 获取回路5温度
         *
         * @return huilu5wendu
         */
        public int getHuiLu5WenDu()
        {
            return huilu5wendu;
        }

        /**
         * 设置回路5温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 326, Length = 2)]
        public void setHuiLu5WenDu(int data)
        {
            huilu5wendu = data;
        }

        //室外温度,单位："℃"
        public int shiwaiwendu;

        /**
         * 获取室外温度
         *
         * @return shiwaiwendu
         */
        public int getShiWaiWenDu()
        {
            return shiwaiwendu;
        }

        /**
         * 设置室外温度
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 328, Length = 2)]
        public void setShiWaiWenDu(int data)
        {
            shiwaiwendu = data;
        }

        //蒸汽压力,单位："MPa"
        public float zhengqiyali;

        /**
         * 获取蒸汽压力
         *
         * @return zhengqiyali
         */
        public float getZhengQiYaLi()
        {
            return zhengqiyali;
        }

        /**
         * 设置蒸汽压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 330, Length = 2)]
        public void setZhengQiYaLi(int data)
        {
            zhengqiyali = (float)data / 100;
        }

        //给水压力,单位："MPa"
        public float jishuiyali;

        /**
         * 获取给水压力
         *
         * @return jishuiyali
         */
        public float getJiShuiYaLi()
        {
            return jishuiyali;
        }

        /**
         * 设置给水压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 332, Length = 2)]
        public void setJiShuiYaLi(int data)
        {
            jishuiyali = (float)data / 100;
        }

        //出口压力,单位："MPa"
        public float chukouyali;

        /**
         * 获取出口压力
         *
         * @return chukouyali
         */
        public float getChuKouYaLi()
        {
            return chukouyali;
        }

        /**
         * 设置出口压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 334, Length = 2)]
        public void setChuKouYaLi(int data)
        {
            chukouyali = (float)data / 100;
        }

        //入口压力,单位："MPa"
        public float rukouyali;

        /**
         * 获取入口压力
         *
         * @return rukouyali
         */
        public float getRuKouYaLi()
        {
            return rukouyali;
        }

        /**
         * 设置入口压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 336, Length = 2)]
        public void setRuKouYaLi(int data)
        {
            rukouyali = (float)data / 100;
        }

        //炉膛压力,单位："Pa"
        public int lutangyali;

        /**
         * 获取炉膛压力
         *
         * @return lutangyali
         */
        public int getLuTangYaLi()
        {
            return lutangyali;
        }

        /**
         * 设置炉膛压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 338, Length = 2)]
        public void setLuTangYaLi(int data)
        {
            lutangyali = data;
        }

        //炉膛出口压力,单位："Pa"
        public int lutangchukouyali;

        /**
         * 获取炉膛出口压力
         *
         * @return lutangchukouyali
         */
        public int getLuTangChuKouYaLi()
        {
            return lutangchukouyali;
        }

        /**
         * 设置炉膛出口压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 340, Length = 2)]
        public void setLuTangChuKouYaLi(int data)
        {
            lutangchukouyali = data;
        }

        //燃气压力,单位："kPa"
        public int ranqiyali;

        /**
         * 获取燃气压力
         *
         * @return ranqiyali
         */
        public int getRanQiYaLi()
        {
            return ranqiyali;
        }

        /**
         * 设置燃气压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 342, Length = 2)]
        public void setRanQiYaLi(int data)
        {
            ranqiyali = data;
        }

        //一次风压,单位："kPa"
        public int yicifengya;

        /**
         * 获取一次风压
         *
         * @return yicifengya
         */
        public int getYiCiFengYa()
        {
            return yicifengya;
        }

        /**
         * 设置一次风压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 344, Length = 2)]
        public void setYiCiFengYa(int data)
        {
            yicifengya = data;
        }

        //二次风压,单位："kPa"
        public int ecifengya;

        /**
         * 获取二次风压
         *
         * @return ecifengya
         */
        public int getECiFengYa()
        {
            return ecifengya;
        }

        /**
         * 设置二次风压
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 346, Length = 2)]
        public void setECiFengYa(int data)
        {
            ecifengya = data;
        }

        //瞬时燃料量
        public int shunshiranliaoliang;

        /**
         * 获取瞬时燃料量
         *
         * @return shunshiranliaoliang
         */
        public int getShunShiRanLiaoLiang()
        {
            return shunshiranliaoliang;
        }

        /**
         * 设置瞬时燃料量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 348, Length = 2)]
        public void setShunShiRanLiaoLiang(int data)
        {
            shunshiranliaoliang = data;
        }

        //瞬时蒸汽流量
        public int shunshizhengqiliuliang;

        /**
         * 获取瞬时蒸汽流量
         *
         * @return shunshizhengqiliuliang
         */
        public int getShunShiZhengQiLiuLiang()
        {
            return shunshizhengqiliuliang;
        }

        /**
         * 设置瞬时蒸汽流量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 350, Length = 2)]
        public void setShunShiZhengQiLiuLiang(int data)
        {
            shunshizhengqiliuliang = data;
        }

        //瞬时给水流量
        public int shunshijishuiliuliang;

        /**
         * 获取瞬时给水流量
         *
         * @return shunshijishuiliuliang
         */
        public int getShunShiJiShuiLiuLiang()
        {
            return shunshijishuiliuliang;
        }

        /**
         * 设置瞬时给水流量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 352, Length = 2)]
        public void setShunShiJiShuiLiuLiang(int data)
        {
            shunshijishuiliuliang = data;
        }

        //瞬时循环流量
        public int shunshixunhuanliuliang;

        /**
         * 获取瞬时循环流量
         *
         * @return shunshixunhuanliuliang
         */
        public int getShunShiXunHuanLiuLiang()
        {
            return shunshixunhuanliuliang;
        }

        /**
         * 设置瞬时循环流量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 354, Length = 2)]
        public void setShunShiXunHuanLiuLiang(int data)
        {
            shunshixunhuanliuliang = data;
        }

        //瞬时补水流量
        public int shunshibushuiliuliang;

        /**
         * 获取瞬时补水流量
         *
         * @return shunshibushuiliuliang
         */
        public int getShunShiBuShuiLiuLiang()
        {
            return shunshibushuiliuliang;
        }

        /**
         * 设置瞬时补水流量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 356, Length = 2)]
        public void setShunShiBuShuiLiuLiang(int data)
        {
            shunshibushuiliuliang = data;
        }

        //锅炉液位,单位："mm"
        public int guoluyewei;

        /**
         * 获取锅炉液位
         *
         * @return guoluyewei
         */
        public int getGuoLuYeWei()
        {
            return guoluyewei;
        }

        /**
         * 设置锅炉液位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 358, Length = 2)]
        public void setGuoLuYeWei(int data)
        {
            guoluyewei = data;
        }

        //水箱液位,单位："mm"
        public int shuixiangyewei;

        /**
         * 获取水箱液位
         *
         * @return shuixiangyewei
         */
        public int getShuiXiangYeWei()
        {
            return shuixiangyewei;
        }

        /**
         * 设置水箱液位
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 360, Length = 2)]
        public void setShuiXiangYeWei(int data)
        {
            shuixiangyewei = data;
        }

        //排烟氧含量,单位："%"
        public float paiyanyanghanliang;

        /**
         * 获取排烟氧含量
         *
         * @return paiyanyanghanliang
         */
        public float getPaiYanYangHanLiang()
        {
            return paiyanyanghanliang;
        }

        /**
         * 设置排烟氧含量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 362, Length = 2)]
        public void setPaiYanYangHanLiang(int data)
        {
            paiyanyanghanliang = (float)data / 10;
        }

        //炉排速度反馈,单位："%"
        public int lupaisudufankui;

        /**
         * 获取炉排速度反馈
         *
         * @return lupaisudufankui
         */
        public int getLuPaiSuDuFanKui()
        {
            return lupaisudufankui;
        }

        /**
         * 设置炉排速度反馈
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 364, Length = 2)]
        public void setLuPaiSuDuFanKui(int data)
        {
            lupaisudufankui = data;
        }

        //引风输出反馈,单位："%"
        public int yinfengshuchufankui;

        /**
         * 获取引风输出反馈
         *
         * @return yinfengshuchufankui
         */
        public int getYinFengShuChuFanKui()
        {
            return yinfengshuchufankui;
        }

        /**
         * 设置引风输出反馈
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 366, Length = 2)]
        public void setYinFengShuChuFanKui(int data)
        {
            yinfengshuchufankui = data;
        }

        //鼓风输出反馈,单位："%"
        public int gufengshuchufankui;

        /**
         * 获取鼓风输出反馈
         *
         * @return gufengshuchufankui
         */
        public int getGuFengShuChuFanKui()
        {
            return gufengshuchufankui;
        }

        /**
         * 设置鼓风输出反馈
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 368, Length = 2)]
        public void setGuFengShuChuFanKui(int data)
        {
            gufengshuchufankui = data;
        }

        //给水输出反馈,单位："%"
        public int jishuishuchufankui;

        /**
         * 获取给水输出反馈
         *
         * @return jishuishuchufankui
         */
        public int getJiShuiShuChuFanKui()
        {
            return jishuishuchufankui;
        }

        /**
         * 设置给水输出反馈
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 370, Length = 2)]
        public void setJiShuiShuChuFanKui(int data)
        {
            jishuishuchufankui = data;
        }

        //燃烧输出量,单位："%"
        public int ranshaoshuchuliangSetting;

        /**
         * 获取燃烧输出量
         *
         * @return ranshaoshuchuliang
         */
        public int getRanShaoShuChuLiangSetting()
        {
            return ranshaoshuchuliangSetting;
        }

        /**
         * 设置燃烧输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 416, Length = 2)]
        public void setRanShaoShuChuLiangSetting(int data)
        {
            ranshaoshuchuliangSetting = data;
        }

        //循环输出量,单位："%"
        public int xunhuanshuchuliangSetting;

        /**
         * 获取循环输出量
         *
         * @return xunhuanshuchuliang
         */
        public int getXunHuanShuChuLiangSetting()
        {
            return xunhuanshuchuliangSetting;
        }

        /**
         * 设置循环输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 418, Length = 2)]
        public void setXunHuanShuChuLiangSetting(int data)
        {
            xunhuanshuchuliangSetting = data;
        }

        //给水输出量,单位："%"
        public int jishuishuchuliangSetting;

        /**
         * 获取给水输出量
         *
         * @return jishuishuchuliang
         */
        public int getJiShuiShuChuLiangSetting()
        {
            return jishuishuchuliangSetting;
        }

        /**
         * 设置给水输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 420, Length = 2)]
        public void setJiShuiShuChuLiangSetting(int data)
        {
            jishuishuchuliangSetting = data;
        }

        //引风输出量,单位："%"
        public int yinfengshuchuliangSetting;

        /**
         * 获取引风输出量
         *
         * @return yinfengshuchuliang
         */
        public int getYinFengShuChuLiangSetting()
        {
            return yinfengshuchuliangSetting;
        }

        /**
         * 设置引风输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 422, Length = 2)]
        public void setYinFengShuChuLiangSetting(int data)
        {
            yinfengshuchuliangSetting = data;
        }

        //鼓风输出量,单位："%"
        public int gufengshuchuliangSetting;

        /**
         * 获取鼓风输出量
         *
         * @return gufengshuchuliang
         */
        public int getGuFengShuChuLiangSetting()
        {
            return gufengshuchuliangSetting;
        }

        /**
         * 设置鼓风输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 424, Length = 2)]
        public void setGuFengShuChuLiangSetting(int data)
        {
            gufengshuchuliangSetting = data;
        }

        //二次鼓风输出量,单位："%"
        public int ecigufengshuchuliangSetting;

        /**
         * 获取二次鼓风输出量
         *
         * @return ecigufengshuchuliang
         */
        public int getECiGuFengShuChuLiangSetting()
        {
            return ecigufengshuchuliangSetting;
        }

        /**
         * 设置二次鼓风输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 426, Length = 2)]
        public void setECiGuFengShuChuLiangSetting(int data)
        {
            ecigufengshuchuliangSetting = data;
        }

        //炉排或进料输出量,单位："%"
        public int lupaihuojinliaoshuchuliangSetting;

        /**
         * 获取炉排或进料输出量
         *
         * @return lupaihuojinliaoshuchuliang
         */
        public int getLuPaiHuoJinLiaoShuChuLiangSetting()
        {
            return lupaihuojinliaoshuchuliangSetting;
        }

        /**
         * 设置炉排或进料输出量
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 428, Length = 2)]
        public void setLuPaiHuoJinLiaoShuChuLiangSetting(int data)
        {
            lupaihuojinliaoshuchuliangSetting = data;
        }

        #endregion
        #region   设定参数
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
        [Attributes.Byte(StartIndex = 544, Length = 2)]
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
        [Attributes.Byte(StartIndex = 546, Length = 2)]
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
        [Attributes.Byte(StartIndex = 548, Length = 2)]
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
        [Attributes.Byte(StartIndex = 550, Length = 2)]
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
        [Attributes.Byte(StartIndex = 552, Length = 2)]
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
        [Attributes.Byte(StartIndex = 554, Length = 2)]
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
        [Attributes.Byte(StartIndex = 556, Length = 2)]
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
        [Attributes.Byte(StartIndex = 558, Length = 2)]
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
        [Attributes.Byte(StartIndex = 560, Length = 2)]
        public void setGuanBengWenDuSetting(int data)
        {
            guanbengwenduSetting = data;
        }

        //报警压力,单位："MPa"
        public float baojingyaliSetting;

        /**
         * 获取报警压力
         *
         * @return baojingyali
         */
        public float getBaoJingYaLiSetting()
        {
            return baojingyaliSetting;
        }

        /**
         * 设置报警压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 562, Length = 2)]
        public void setBaoJingYaLiSetting(int data)
        {
            baojingyaliSetting = (float)data / 100;
        }

        //停炉压力,单位："MPa"
        public float tingluyaliSetting;

        /**
         * 获取停炉压力
         *
         * @return tingluyali
         */
        public float getTingLuYaLiSetting()
        {
            return tingluyaliSetting;
        }

        /**
         * 设置停炉压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 564, Length = 2)]
        public void setTingLuYaLiSetting(int data)
        {
            tingluyaliSetting = (float)data / 100;
        }

        //目标压力,单位："MPa"
        public float mubiaoyaliSetting;

        /**
         * 获取目标压力
         *
         * @return mubiaoyali
         */
        public float getMuBiaoYaLiSetting()
        {
            return mubiaoyaliSetting;
        }

        /**
         * 设置目标压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 566, Length = 2)]
        public void setMuBiaoYaLiSetting(int data)
        {
            mubiaoyaliSetting = (float)data / 100;
        }

        //启炉压力,单位："MPa"
        public float qiluyaliSetting;

        /**
         * 获取启炉压力
         *
         * @return qiluyali
         */
        public float getQiLuYaLiSetting()
        {
            return qiluyaliSetting;
        }
        /**
         * 设置启炉压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 568, Length = 2)]
        public void setQiLuYaLiSetting(int data)
        {
            qiluyaliSetting = (float)data / 100;
        }
        //转火回差压力,单位："MPa"
        public float zhuanhuohuichayaliSetting;
        /**
         * 获取转火回差压力
         *
         * @return zhuanhuohuichayali
         */
        public float getZhuanHuoHuiChaYaLiSetting()
        {
            return zhuanhuohuichayaliSetting;
        }
        /**
         * 设置转火回差压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 570, Length = 2)]
        public void setZhuanHuoHuiChaYaLiSetting(int data)
        {
            zhuanhuohuichayaliSetting = (float)data / 100;
        }
        //启炉回差压力,单位："MPa"
        public float qiluhuichayaliSetting;

        /**
         * 获取启炉回差压力
         *
         * @return qiluhuichayali
         */
        public float getQiLuHuiChaYaLiSetting()
        {
            return qiluhuichayaliSetting;
        }
        /**
         * 设置启炉回差压力
         *
         * @param data
         */
        [Attributes.Byte(StartIndex = 572, Length = 2)]
        public void setQiLuHuiChaYaLiSetting(int data)
        {
            qiluhuichayaliSetting = (float)data / 100;
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
        [Attributes.Byte(StartIndex = 574, Length = 2)]
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
        [Attributes.Byte(StartIndex = 576, Length = 2)]
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
        [Attributes.Byte(StartIndex = 578, Length = 2)]
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
        [Attributes.Byte(StartIndex = 580, Length = 2)]
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
        [Attributes.Byte(StartIndex = 582, Length = 2)]
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
        [Attributes.Byte(StartIndex = 584, Length = 2)]
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
        [Attributes.Byte(StartIndex = 586, Length = 2)]
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
        [Attributes.Byte(StartIndex = 588, Length = 2)]
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
        [Attributes.Byte(StartIndex = 590, Length = 2)]
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
        [Attributes.Byte(StartIndex = 592, Length = 2)]
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
        [Attributes.Byte(StartIndex = 594, Length = 2)]
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
        [Attributes.Byte(StartIndex = 596, Length = 2)]
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
        [Attributes.Byte(StartIndex = 598, Length = 2)]
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
        [Attributes.Byte(StartIndex = 600, Length = 2)]
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
        [Attributes.Byte(StartIndex = 602, Length = 2)]
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
        [Attributes.Byte(StartIndex = 604, Length = 2)]
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
        [Attributes.Byte(StartIndex = 606, Length = 2)]
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
        [Attributes.Byte(StartIndex = 608, Length = 2)]
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
        [Attributes.Byte(StartIndex = 610, Length = 2)]
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
        [Attributes.Byte(StartIndex = 612, Length = 2)]
        public void setTingZhiShiJian6Setting(int data)
        {
            tingzhishijian6Setting = data;
        }
        #endregion
    }
}
