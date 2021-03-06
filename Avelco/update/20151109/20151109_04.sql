
ALTER proc [dbo].[hrbangluong]
	@thang int,
	@nam int,
	@ma_nv varchar(16)='',
	@ma_bp varchar(16)='',
	@quoc_tich int = 0--0:khong phan biet quoc tich,1:nguoi viet,2:nguoi nuoc ngoai
as
begin
	declare @cong_quy_dinh numeric(18,0),@ngay_dau_ky date
	select @cong_quy_dinh = value1 from options where name ='hr_ngay_chuan'
	if @cong_quy_dinh is null set @cong_quy_dinh =25
	set @ngay_dau_ky = CAST(CAST(@nam AS varchar) + '-' + CAST(@thang AS varchar) + '-1' AS Date)
	select * into #dnv from dnv where (@ma_nv = '' or ma_nv = @ma_nv) and (@ma_bp ='' or ma_bp = @ma_bp) and (ngay_nghi_viec is null or ngay_nghi_viec > @ngay_dau_ky)
	if @quoc_tich = 2 delete #dnv where  quoc_tich ='00000001' or quoc_tich=''
	if @quoc_tich = 1 delete #dnv where  quoc_tich <>'00000001' and  quoc_tich<>''
	
	select * into #bangtinhluong from bangtinhluong
		where thang = @thang and nam = @nam
		and ma_nv in (select ma_nv from #dnv)
		
	select a.ma_nv,a.ma_bp,a.ten_nv,a.nv_thu_viec,a.quoc_tich,@thang as thang,@nam as nam
			,@cong_quy_dinh as cong_quy_dinh
			,isnull(b.ngay_cong,0) as ngay_cong --tinh tu bang cham cong theo thoi gian
			,isnull(a.luong_bhxh,0) as luong_bhxh
			,isnull(a.luong_co_ban,0) as luong_co_ban
			,isnull(a.phu_cap_ky_nang,0) as phu_cap_ky_nang
			,isnull(b.phu_cap_chuyen_can,a.phu_cap_chuyen_can) as phu_cap_chuyen_can
			,isnull(a.phu_cap_chuc_vu,0) as phu_cap_chuc_vu
			,isnull(a.phu_cap_com_trua,0) as phu_cap_com_trua
			,isnull(a.phu_cap_xang,0) as phu_cap_xang
			,isnull(c.tro_cap,0) as phu_cap_tieng_nhat--lay tu tiengnhat table
			,isnull(a.phu_cap_ket_hon,0) as phu_cap_ket_hon			
			,isnull(b.luong_san_pham,0) as luong_san_pham --tinh tu bang luong thanh pham						
			,isnull(b.so_gio_tang_ca,0) as so_gio_tang_ca --tinh
			,isnull(b.so_gio_ban_thoi_gian,0) as so_gio_ban_thoi_gian --tinh
			,isnull(b.so_gio_ngay_nghi,0) as so_gio_ngay_nghi --tinh
			,isnull(b.so_gio_le_tet,0) as so_gio_le_tet --tinh
			,isnull(b.gio_nghi_buoc,0) as gio_nghi_buoc --tu go			
			,isnull(b.luong_tang_ca,0) as luong_tang_ca --tinh
			,isnull(b.luong_ban_thoi_gian,0) as luong_ban_thoi_gian --tinh
			,isnull(b.luong_ngay_nghi,0) as luong_ngay_nghi --tinh
			,isnull(b.luong_le_tet,0) as luong_le_tet --tinh
			,isnull(b.luong_nghi_buoc,0) as luong_nghi_buoc --cong thuc
			,isnull(b.phu_cap_cong_tac,0) as phu_cap_cong_tac --tu go			
			,isnull(b.tt_khau_tru_tncn,0) as tt_khau_tru_tncn -- cong thuc
			,isnull(b.gio_bo_sung,0) as gio_bo_sung --tu go			
			,isnull(b.luong_bo_sung,0) as luong_bo_sung --cong thuc
			,isnull(b.hoan_thue,0) as hoan_thue --hoan thue
			,cast(0 as numeric(18,5)) as tong_cong	
			,cast(0 as numeric(18,5)) as luong_chinh					
			,cast(0 as numeric(18,5)) as bhxh_t,cast(0 as numeric(18,5)) as bhxh_c
			,cast(0 as numeric(18,5)) as bhyt_t,cast(0 as numeric(18,5)) as bhyt_c
			,cast(0 as numeric(18,5)) as bhtn_t,cast(0 as numeric(18,5)) as bhtn_c
			,cast(0 as numeric(18,5)) as cong_t,cast(0 as numeric(18,5)) as cong_c
			,cast(0 as numeric(18,5)) as cong_tc
			
			,cast(0 as numeric(18,5)) as cong_doan_t,cast(0 as numeric(18,5)) as cong_doan_c
			,cast(0 as numeric(18,5)) as cong_doan
			,isnull(b.so_ngay_nghi,0) as so_ngay_nghi
			,isnull(b.nghi_tru_luong,0) as nghi_tru_luong
			
			,isnull(b.luong_thanh_tich,0) as luong_thanh_tich
			,isnull(b.thu_nhap_chiu_thue,0) as thu_nhap_chiu_thue
			,isnull(b.giam_tru_ca_nhan,9000000) as giam_tru_ca_nhan
			,isnull(a.giam_tru_phu_thuoc,0) as giam_tru_phu_thuoc
			,isnull(b.tong_giam_tru,0) as tong_giam_tru
			,isnull(b.thu_nhap_tinh_thue,0) as thu_nhap_tinh_thue
			,isnull(b.thue_tncn,0) as thue_tncn
			
			,isnull(b.tong_tru,0) as tong_tru
			,isnull(b.thuc_tra,0) as thuc_tra
			,cast(0 as numeric(18,5)) as tong_luong
			
			,a.tg_bh_xh,a.tg_bh_yt,a.tg_bh_tn,a.tg_bh_cd,a.ma_nt,a.ngay_nghi_viec
		into #report
		from #dnv a left join #bangtinhluong b on a.ma_nv = b.ma_nv left join tiengnhat c on a.tieng_nhat = c.ma
	--tinh luong thu viec
	--update #report set luong_co_ban = luong_co_ban *80/100 where nv_thu_viec = 1
	--tinh luong san pham
	select stt_rec into #mbtp from mbtp where year(ngay_ct) = @nam and month(ngay_ct) = @thang
	select ma_nv,sum(result) as luong_san_pham into #luongthanhpham from dbtp
	 where stt_rec in (select stt_rec from #mbtp) and ma_nv in (select ma_nv from #report) group by ma_nv
	update #report set luong_san_pham = isnull(b.luong_san_pham,0) from #report a left join #luongthanhpham b on a.ma_nv = b.ma_nv
	--luong nghi buoc
	update #report set luong_nghi_buoc = (((luong_co_ban + phu_cap_ky_nang)/25)/8) * gio_nghi_buoc
	--tinh luong tang ca
	update #report set luong_tang_ca =((luong_co_ban +phu_cap_ky_nang)/25/8)*so_gio_tang_ca *1.5	
	--tinh luong ngay nghi
	update #report set luong_ngay_nghi =((luong_co_ban +phu_cap_ky_nang)/25/8)*so_gio_ngay_nghi *2
	--tinh luong le tet
	update #report set luong_le_tet =((luong_co_ban +phu_cap_ky_nang)/25/8)*so_gio_le_tet *3
	--luong ban thoi gian
	-- luong bo sung
	--update #report set luong_bo_sung = ((luong_co_ban +phu_cap_ky_nang)/25/8) * gio_bo_sung
	--tinh tong luong
	
	update #report set tong_cong = luong_co_ban 
		+ phu_cap_ky_nang + phu_cap_chuyen_can + phu_cap_chuc_vu + phu_cap_com_trua + phu_cap_xang + phu_cap_tieng_nhat + phu_cap_ket_hon 
		+ luong_san_pham + luong_tang_ca + luong_ban_thoi_gian + luong_ngay_nghi + luong_le_tet + phu_cap_cong_tac + luong_nghi_buoc + luong_bo_sung
		+ hoan_thue
	--luong bao hiem xa hoi
	update #report set luong_bhxh = luong_co_ban + phu_cap_ky_nang + phu_cap_chuyen_can + phu_cap_chuc_vu + phu_cap_com_trua + phu_cap_xang + phu_cap_tieng_nhat
	--danh sach khong dong bao hiem
	select ma_nv into #ngungdong from dmqtdong_bhxh  where @thang* @nam > year(tu_ngay) * month(tu_ngay) and @thang* @nam > year(den_ngay) * month(den_ngay) 
	select ma_nv,day(ngay_nghi_viec) as ngay_nghi into #nghi_viec from #report where ngay_nghi_viec is not null 
	--danh sach nguoi nuoc ngoai 
	select ma_nv,cu_tru,di_chuyen_noi_bo into #nguoi_nuoc_ngoai from dnv where  quoc_tich <>'00000001' and quoc_tich<>''
	--tinh bhxh,bhyt,bhtn
	update #report set bhxh_t = round(luong_bhxh * 8/100,0) where tg_bh_xh=1 and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21)--quoc_tich ='00000001' or quoc_tich=''
	update #report set bhyt_t = round(luong_bhxh * 1.5/100,0) where tg_bh_yt=1  and ma_nv not in (select ma_nv from #ngungdong)--nn_cu_chu_nb = 0
	update #report set bhtn_t = round(luong_bhxh * 1/100,0) where tg_bh_tn=1  and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21) --quoc_tich ='00000001' or quoc_tich=''
	update #report set cong_t =bhxh_t+ bhyt_t+bhtn_t
	
	update #report set bhxh_c = round(luong_bhxh * 18/100,0) where tg_bh_xh=1  and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21)--quoc_tich ='00000001' or quoc_tich=''
	update #report set bhyt_c = round(luong_bhxh * 3/100,0) where tg_bh_yt=1  and ma_nv not in (select ma_nv from #ngungdong)--nn_cu_chu_nb = 0
	update #report set bhtn_c = round(luong_bhxh * 1/100,0) where tg_bh_tn=1  and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21)--quoc_tich ='00000001' or quoc_tich=''
	update #report set cong_c =bhxh_c+ bhyt_c+bhtn_c
	
	update #report set cong_tc = cong_t + cong_c
	--chi phi cong doan
	update #report set cong_doan_c = round(luong_bhxh * 2/100,0) where tg_bh_cd = 1  and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21)
	update #report set cong_doan_t = round(luong_bhxh * 1/100,0) where tg_bh_cd = 1  and ma_nv not in (select ma_nv from #ngungdong) and ma_nv not in (select ma_nv from #nghi_viec where ngay_nghi< 21)
	update #report set cong_doan_t = 83000 where cong_doan_t > 83000
	update #report set cong_doan = cong_doan_c+cong_doan_t
	--nghi tru luong
	update #report set nghi_tru_luong = round(((luong_co_ban + phu_cap_ky_nang + phu_cap_chuyen_can + phu_cap_chuc_vu + phu_cap_com_trua + phu_cap_xang + phu_cap_tieng_nhat + phu_cap_ket_hon  - phu_cap_chuyen_can)/25)*(so_ngay_nghi/8),0) 
	--thue tncn
	update #report set thu_nhap_chiu_thue = tong_cong + luong_thanh_tich - phu_cap_chuyen_can - nghi_tru_luong
	update #report set thu_nhap_tinh_thue = thu_nhap_chiu_thue - bhxh_t-bhyt_t-bhtn_t - giam_tru_ca_nhan - giam_tru_phu_thuoc
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 5/100,0) where thu_nhap_tinh_thue<=5000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 10/100,0) - 250000 where thu_nhap_tinh_thue > 5000000 and thu_nhap_tinh_thue<=10000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 15/100,0) - 750000 where thu_nhap_tinh_thue > 10000000 and thu_nhap_tinh_thue<=18000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 20/100,0) - 1650000 where thu_nhap_tinh_thue > 18000000 and thu_nhap_tinh_thue<=32000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 25/100,0) - 3250000 where thu_nhap_tinh_thue > 32000000 and thu_nhap_tinh_thue<=52000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 30/100,0) - 5850000 where thu_nhap_tinh_thue > 52000000 and thu_nhap_tinh_thue<=80000000
	update #report set thue_tncn =round(thu_nhap_tinh_thue * 35/100,0) - 9850000 where thu_nhap_tinh_thue > 80000000
	update #report set thu_nhap_tinh_thue =0 where thu_nhap_tinh_thue < 0
	update #report set thue_tncn =0 where thue_tncn < 0
	--dieu chinh thue thu nhap ca nhan cho nguoi nuoc ngoai
	update #report set thue_tncn = thu_nhap_tinh_thue*(1-20/100) where ma_nv in (select ma_nv from #nguoi_nuoc_ngoai where cu_tru=0)

	update #report set thue_tncn = 0,thu_nhap_chiu_thue=0,thu_nhap_tinh_thue=0
	 where ma_nv in (select ma_nv from #nguoi_nuoc_ngoai where cu_tru=1)

	--tong tru
	update #report set tong_tru = bhxh_t + bhyt_t + bhtn_t + cong_doan_t + nghi_tru_luong + thue_tncn
	--thuc tra
	update #report set thuc_tra = tong_cong - tong_tru
	update #report set tong_luong = tong_cong + luong_thanh_tich
	--tinh luong thu viec
	update #report set tong_luong = tong_luong *85/100 where nv_thu_viec = 1
	
	--thanh tich thuc tra
	update #report set luong_chinh = tong_cong - (phu_cap_chuyen_can +nghi_tru_luong)
	-- tong cong thu nhap cn
	update #report set tong_giam_tru = bhxh_t + bhyt_t + bhtn_t + phu_cap_com_trua + giam_tru_ca_nhan + giam_tru_phu_thuoc
	-- Tong thanh toan khau tru thu nhap ca nhan
	update #report set tt_khau_tru_tncn = luong_thanh_tich - thue_tncn
	update #report set tt_khau_tru_tncn = 0 where tt_khau_tru_tncn < 0
	--ket qua

	select * from #report
end
