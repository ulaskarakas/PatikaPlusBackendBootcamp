-- 1. test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
/*
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);
*/

-- 2. Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
/*
insert into employee (name, birthday, email) values ('Carlye Akred', '1917-04-06', 'cakred0@addthis.com');
insert into employee (name, birthday, email) values ('Marianna Jemmison', '1943-03-21', null);
insert into employee (name, birthday, email) values ('Paloma Oddboy', '1938-02-12', 'poddboy2@skype.com');
insert into employee (name, birthday, email) values ('Alasdair Toe', '1928-04-07', 'atoe3@guardian.co.uk');
insert into employee (name, birthday, email) values ('Elita Carncross', '1933-02-15', 'ecarncross4@redcross.org');
insert into employee (name, birthday, email) values ('Hayley Klugel', '1910-07-06', 'hklugel5@hp.com');
insert into employee (name, birthday, email) values ('Nikki Hibbart', '1974-04-13', 'nhibbart6@over-blog.com');
insert into employee (name, birthday, email) values ('Cathie McFadzean', '1909-10-04', 'cmcfadzean7@chicagotribune.com');
insert into employee (name, birthday, email) values ('Johny Konertz', '1947-03-09', 'jkonertz8@dagondesign.com');
insert into employee (name, birthday, email) values ('Karolina Gisburn', '1999-11-02', 'kgisburn9@barnesandnoble.com');
insert into employee (name, birthday, email) values ('Mateo Diffley', '1979-08-18', 'mdiffleya@geocities.jp');
insert into employee (name, birthday, email) values ('Missy Miguel', '1933-09-03', 'mmiguelb@is.gd');
insert into employee (name, birthday, email) values ('Olva Greenrde', '1991-09-01', 'ogreenrdec@is.gd');
insert into employee (name, birthday, email) values ('Kriste Coulthard', '1975-03-05', null);
insert into employee (name, birthday, email) values ('Hestia Denzilow', '1915-12-23', 'hdenzilowe@jalbum.net');
insert into employee (name, birthday, email) values ('Carlin Slorance', '1982-02-19', 'cslorancef@furl.net');
insert into employee (name, birthday, email) values ('Niki Dielhenn', '1956-07-05', 'ndielhenng@archive.org');
insert into employee (name, birthday, email) values ('Ivy Marquess', '1936-03-09', 'imarquessh@dyndns.org');
insert into employee (name, birthday, email) values ('Giffy Gumly', '1918-02-03', 'ggumlyi@canalblog.com');
insert into employee (name, birthday, email) values ('Rodina Wands', null, 'rwandsj@woothemes.com');
insert into employee (name, birthday, email) values ('Sven Joinson', '1921-08-07', 'sjoinsonk@dagondesign.com');
insert into employee (name, birthday, email) values ('Jareb Dabbes', '1943-04-29', null);
insert into employee (name, birthday, email) values ('Tiffany Ronan', null, 'tronanm@rambler.ru');
insert into employee (name, birthday, email) values ('Collette Krook', '1926-06-17', 'ckrookn@noaa.gov');
insert into employee (name, birthday, email) values ('Kathe Leverton', '1992-12-13', 'klevertono@auda.org.au');
insert into employee (name, birthday, email) values ('Hasty Peyton', '1924-06-30', null);
insert into employee (name, birthday, email) values ('Tessie Teresia', '1936-06-23', 'tteresiaq@illinois.edu');
insert into employee (name, birthday, email) values ('Arlin Poundford', '1918-02-21', 'apoundfordr@taobao.com');
insert into employee (name, birthday, email) values ('Lowrance Fittall', '1911-05-15', 'lfittalls@apache.org');
insert into employee (name, birthday, email) values ('Tad Dunster', '1927-02-17', 'tdunstert@webeden.co.uk');
insert into employee (name, birthday, email) values ('De Varlow', '1904-12-31', 'dvarlowu@mit.edu');
insert into employee (name, birthday, email) values ('Marketa Ruddock', '1922-02-27', 'mruddockv@businessweek.com');
insert into employee (name, birthday, email) values ('Tamas Stichall', '1966-04-08', null);
insert into employee (name, birthday, email) values ('Bradford Radke', '1996-07-29', 'bradkex@facebook.com');
insert into employee (name, birthday, email) values ('Sanderson Rhymes', '1919-10-16', 'srhymesy@feedburner.com');
insert into employee (name, birthday, email) values ('Austin Margrie', '1940-01-15', 'amargriez@geocities.jp');
insert into employee (name, birthday, email) values ('Phyllys Kettel', null, 'pkettel10@uol.com.br');
insert into employee (name, birthday, email) values ('Cherise Clitsome', '1981-03-29', 'cclitsome11@msu.edu');
insert into employee (name, birthday, email) values ('Velma Petrecz', '1968-01-10', 'vpetrecz12@networkadvertising.org');
insert into employee (name, birthday, email) values ('Salvatore Pott', '1904-08-02', 'spott13@miitbeian.gov.cn');
insert into employee (name, birthday, email) values ('Brigitte Mc Dermid', '1907-12-08', 'bmc14@youtube.com');
insert into employee (name, birthday, email) values ('Sinclare Laurenz', '1974-09-26', 'slaurenz15@bizjournals.com');
insert into employee (name, birthday, email) values ('Flinn Hayles', '1968-11-08', 'fhayles16@mail.ru');
insert into employee (name, birthday, email) values ('Gordan Scammell', null, 'gscammell17@economist.com');
insert into employee (name, birthday, email) values ('Moe Tidmarsh', '1960-02-03', 'mtidmarsh18@senate.gov');
insert into employee (name, birthday, email) values ('Murielle O''Connolly', '1988-05-17', 'moconnolly19@google.pl');
insert into employee (name, birthday, email) values ('Brittani Mark', '1985-07-21', null);
insert into employee (name, birthday, email) values ('Gwendolyn Mouse', '1925-07-08', 'gmouse1b@nytimes.com');
insert into employee (name, birthday, email) values ('Llywellyn Darthe', '1927-11-29', 'ldarthe1c@businessinsider.com');
insert into employee (name, birthday, email) values ('Jesse Bickerstasse', '1979-08-07', 'jbickerstasse1d@moonfruit.com');
*/

-- 3. Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
/*
UPDATE employee
SET name = 'Mehmet Erdem',
	birthday = '1967-12-05',
	email = 'mehmet@erdem.com'
WHERE id = 1;

UPDATE employee
SET name = 'Ahmet Ekim',
	birthday = '1962-07-11',
	email = 'ahmet@ekim.com'
WHERE id = 10;

UPDATE employee
SET name = 'Burak Polat',
	birthday = '1955-11-07',
	email = 'burak@polat.com'
WHERE id = 20;

UPDATE employee
SET name = 'Umut Erdi',
	birthday = '1974-03-09',
	email = 'umut@erdi.com'
WHERE id = 30;

UPDATE employee
SET name = 'Selma Burcu',
	birthday = '1980-09-25',
	email = 'selma@burcu.com'
WHERE id = 40;
*/

-- 4. Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
/*
DELETE FROM employee
WHERE id = 1;

DELETE FROM employee
WHERE id = 10;

DELETE FROM employee
WHERE id = 20;

DELETE FROM employee
WHERE id = 30;

DELETE FROM employee
WHERE id = 40;
*/
