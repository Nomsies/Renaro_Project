-- membuat tabel admin --
create table admins
(
	id_admin serial primary key,
	nama varchar(30),
	username varchar(30),
	password varchar(30)
);

-- membuat tabel daya --
create table daya
(
	id_daya serial primary key,
	daya varchar(10),
	biaya_kwh int
);

-- membuat tabel pelanggan --
create table pelanggan
(
	id_pelanggan serial primary key,
	no_listrik varchar(10) unique,
	nama varchar(30),
	alamat varchar(30),
	id_daya int,
	
	constraint pelanggan_fk_daya foreign key(id_daya)
		references daya(id_daya)
);

-- membuat tabel transaksi --
create table transaksi
(
	id_transaksi serial primary key,
	no_listrik varchar(10),
	tgl_transaksi date,
	daya varchar(10),
	biaya_kwh int,
	kwh_terakhir int,
	kwh_sekarang int,
	biaya_admin int,
	tagihan int,
	bayaran int,
	kembalian int,
	
	constraint transaksi_fk_pelanggan foreign key (no_listrik)
		references pelanggan (no_listrik)
);

-- menambahkan data pada tabel daya --
insert into daya (daya, biaya_kwh)
values ('450 VA', 415),
('900 VA', 1352),
('1300 VA', 1445);

-- menambahkan data pada tabel admins --
insert into admins (nama, username, password)
values ('Reza Octa Fahlevi', 'reza', 'reza123'),
('Muhammad Nafiz Azalea', 'nafiz', 'nafiz123'),
('Reofaldo Michelangelo Lau', 'reo', 'reo123');

-- menambahkan data pada tabel pelanggan -- 
insert into pelanggan (no_listrik, nama, alamat, id_daya)
values ('2124101001', 'Ariana Nandana', 'Jl. Mawar, No. 20', 3),
('2124101002', 'Pandena Angkasa', 'Jl. Melati, No. 60', 2),
('2124101003', 'Kamelia Dianita', 'Jl. Anggrek, No. 45', 1);

-- menambahkan data pada tabel transaksi --
insert into transaksi (no_listrik, tgl_transaksi, daya, biaya_kwh, kwh_terakhir, kwh_sekarang, biaya_admin, tagihan, bayaran, kembalian)
values ('2124101001', '2022-05-28', '1300 VA', 1445, 0, 35, 2500, 53075, 70000, 16925),
('2124101003', '2022-05-29', '450 VA', 415, 155, 194, 2500, 18685, 20000, 1315),
('2124101002', '2022-05-31', '900 VA', 1352, 172, 232, 2500, 83620, 100000, 16380);

-- membuat fungsi login --
create function login(_username varchar, _password varchar)
returns int as
$$
begin
	if (select count(*) from admins where username = _username and password = _password) then
		return 1;
	else
		return 0;
	end if;
end
$$
language plpgsql;

-- membuat fungsi menambahkan data pelanggan --
create function add_pelanggan (_nolistrik varchar, _nama varchar, _alamat varchar, _iddaya int)
returns int as
$$
begin
	insert into pelanggan(no_listrik, nama, alamat, id_daya)
	values (_nolistrik, _nama, _alamat, _iddaya);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$
language plpgsql;

-- membuat fungsi untuk meng-update data pada tabel pelanggan --
create function upd_pelanggan (_nolistrik varchar, _nama varchar, _iddaya int)
returns int as
$$
begin
	update pelanggan set nama = _nama, daya = _iddaya where no_listrik = _nolistrik;
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$
language plpgsql;

-- membuat fungsi untuk menambahkan baris data pada tabel transaksi --
create function add_transaksi (_nolistrik varchar, _tgltransaksi date, _daya varchar, _biayakwh int, _kwhterakhir int, _kwhsekarang int, _biayaadmin int, _tagihan int, _bayaran int, _kembalian int)
returns int as
$$
begin
	insert into transaksi (no_listrik, tgl_transaksi, daya, biaya_kwh, kwh_terakhir, kwh_sekarang, biaya_admin, tagihan, bayaran, kembalian)
	values (_nolistrik, _tgltransaksi, _daya, _biayakwh, _kwhterakhir, _kwhsekarang, _biayaadmin, _tagihan, _bayaran, _kembalian);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$
language plpgsql

select * from transaksi