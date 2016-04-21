using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuizGenerator : MonoBehaviour {

	public int correct;

	public Text soalNya;
	public Button pilA;
	public Button pilB;
	public Button pilC;
	public Button pilD;

	public Text Score;
	public int yourScore = 0;

	public GameObject QuizTime;
	public GameObject YouWin;
	public Text youWinScore;

	// Use this for initialization
	void Start () {
		pilA.onClick.AddListener (delegate { Answering(1); } );
		pilB.onClick.AddListener (delegate { Answering(2); } );
		pilC.onClick.AddListener (delegate { Answering(3); } );
		pilD.onClick.AddListener (delegate { Answering(4); } );
		QuizTime.SetActive (false);
		YouWin.SetActive (false);
	}

	void Update(){
		Score.text = "Score : " + yourScore;
		youWinScore.text = "Score : " + yourScore;
	}
	
	public void GenerateQuiz(int soal){
		QuizTime.SetActive (true);

		//Soal Matematika
		if (soal == 1) {
			soalNya.text = "2 + 2 =";
			pilA.GetComponentInChildren<Text>().text = "1";
			pilB.GetComponentInChildren<Text>().text = "2";
			pilC.GetComponentInChildren<Text>().text = "3";
			pilD.GetComponentInChildren<Text>().text = "4";

			correct = 4;
		}
		if (soal == 2) {
			soalNya.text = "6 + 9 =";
			pilA.GetComponentInChildren<Text>().text = "15";
			pilB.GetComponentInChildren<Text>().text = "14";
			pilC.GetComponentInChildren<Text>().text = "13";
			pilD.GetComponentInChildren<Text>().text = "12";

			correct = 1;
		}
		if (soal == 3) {
			soalNya.text = "15 + 25 =";
			pilA.GetComponentInChildren<Text>().text = "45";
			pilB.GetComponentInChildren<Text>().text = "40";
			pilC.GetComponentInChildren<Text>().text = "50";
			pilD.GetComponentInChildren<Text>().text = "55";

			correct = 2;
		}
		if (soal == 4) {
			soalNya.text = "78 + 22 =";
			pilA.GetComponentInChildren<Text>().text = "100";
			pilB.GetComponentInChildren<Text>().text = "120";
			pilC.GetComponentInChildren<Text>().text = "330";
			pilD.GetComponentInChildren<Text>().text = "170";

			correct = 1;
		}
		if (soal == 5) {
			soalNya.text = "54 + 15 =";
			pilA.GetComponentInChildren<Text>().text = "66";
			pilB.GetComponentInChildren<Text>().text = "69";
			pilC.GetComponentInChildren<Text>().text = "70";
			pilD.GetComponentInChildren<Text>().text = "90";

			correct = 2;
		}
		if (soal == 6) {
			soalNya.text = "75 - 25 =";
			pilA.GetComponentInChildren<Text>().text = "50";
			pilB.GetComponentInChildren<Text>().text = "45";
			pilC.GetComponentInChildren<Text>().text = "53";
			pilD.GetComponentInChildren<Text>().text = "36";

			correct = 1;
		}
		if (soal == 7) {
			soalNya.text = "5 – 5 =";
			pilA.GetComponentInChildren<Text>().text = "1";
			pilB.GetComponentInChildren<Text>().text = "10";
			pilC.GetComponentInChildren<Text>().text = "0";
			pilD.GetComponentInChildren<Text>().text = "5";

			correct = 3;
		}
		if (soal == 8) {
			soalNya.text = "80 – 9 =";
			pilA.GetComponentInChildren<Text>().text = "78";
			pilB.GetComponentInChildren<Text>().text = "71";
			pilC.GetComponentInChildren<Text>().text = "90";
			pilD.GetComponentInChildren<Text>().text = "89";

			correct = 2;
		}
		if (soal == 9) {
			soalNya.text = "66 – 8 =";
			pilA.GetComponentInChildren<Text>().text = "58";
			pilB.GetComponentInChildren<Text>().text = "52";
			pilC.GetComponentInChildren<Text>().text = "70";
			pilD.GetComponentInChildren<Text>().text = "23";

			correct = 1;
		}
		if (soal == 10) {
			soalNya.text = "23 – 19 =";
			pilA.GetComponentInChildren<Text>().text = "5";
			pilB.GetComponentInChildren<Text>().text = "4";
			pilC.GetComponentInChildren<Text>().text = "9";
			pilD.GetComponentInChildren<Text>().text = "3";

			correct = 2;
		}
		if (soal == 11) {
			soalNya.text = "5 x 7 =";
			pilA.GetComponentInChildren<Text>().text = "35";
			pilB.GetComponentInChildren<Text>().text = "40";
			pilC.GetComponentInChildren<Text>().text = "45";
			pilD.GetComponentInChildren<Text>().text = "50";

			correct = 2;
		}
		if (soal == 12) {
			soalNya.text = "20 x 5 =";
			pilA.GetComponentInChildren<Text>().text = "100";
			pilB.GetComponentInChildren<Text>().text = "25";
			pilC.GetComponentInChildren<Text>().text = "150";
			pilD.GetComponentInChildren<Text>().text = "50";

			correct = 1;
		}
		if (soal == 13) {
			soalNya.text = "55 x 2 =";
			pilA.GetComponentInChildren<Text>().text = "150";
			pilB.GetComponentInChildren<Text>().text = "110";
			pilC.GetComponentInChildren<Text>().text = "100";
			pilD.GetComponentInChildren<Text>().text = "170";

			correct = 2;
		}
		if (soal == 14) {
			soalNya.text = "70 : 5=";
			pilA.GetComponentInChildren<Text>().text = "9";
			pilB.GetComponentInChildren<Text>().text = "75";
			pilC.GetComponentInChildren<Text>().text = "350";
			pilD.GetComponentInChildren<Text>().text = "14";

			correct = 4;
		}
		if (soal == 15) {
			soalNya.text = "82 : 2 =";
			pilA.GetComponentInChildren<Text>().text = "78";
			pilB.GetComponentInChildren<Text>().text = "99";
			pilC.GetComponentInChildren<Text>().text = "41";
			pilD.GetComponentInChildren<Text>().text = "40";

			correct = 3;
		}
		if (soal == 16) {
			soalNya.text = "½ + ½ =";
			pilA.GetComponentInChildren<Text>().text = "1";
			pilB.GetComponentInChildren<Text>().text = "2";
			pilC.GetComponentInChildren<Text>().text = "4";
			pilD.GetComponentInChildren<Text>().text = "8";

			correct = 1;
		}
		if (soal == 17) {
			soalNya.text = "7/8 + 8/8 =";
			pilA.GetComponentInChildren<Text>().text = "9/8";
			pilB.GetComponentInChildren<Text>().text = "18/8";
			pilC.GetComponentInChildren<Text>().text = "23/8";
			pilD.GetComponentInChildren<Text>().text = "15/8";

			correct = 4;
		}
		if (soal == 18) {
			soalNya.text = "80/9 – 75/9 =";
			pilA.GetComponentInChildren<Text>().text = "7/9";
			pilB.GetComponentInChildren<Text>().text = "10/9";
			pilC.GetComponentInChildren<Text>().text = "5/9";
			pilD.GetComponentInChildren<Text>().text = "1/9";

			correct = 3;
		}
		if (soal == 19) {
			soalNya.text = "99/100 – 71/100 =";
			pilA.GetComponentInChildren<Text>().text = "29/100";
			pilB.GetComponentInChildren<Text>().text = "28/100";
			pilC.GetComponentInChildren<Text>().text = "50/100";
			pilD.GetComponentInChildren<Text>().text = "30/100";

			correct = 2;
		}
		if (soal == 20) {
			soalNya.text = "23/4 – 15/4 =";
			pilA.GetComponentInChildren<Text>().text = "8/4";
			pilB.GetComponentInChildren<Text>().text = "9/4";
			pilC.GetComponentInChildren<Text>().text = "3/4";
			pilD.GetComponentInChildren<Text>().text = "5/4";

			correct = 1;
		}

		//Soal Bahasa Indonesia
		if (soal == 21) {
			soalNya.text = "apa saja unsur 5W + 1H, yaitu... ";
			pilA.GetComponentInChildren<Text>().text = "what, where, who, when, why, how";
			pilB.GetComponentInChildren<Text>().text = "what, wish, world, who, why, hand";
			pilC.GetComponentInChildren<Text>().text = "when, world, week, what, where, how";
			pilD.GetComponentInChildren<Text>().text = "when, what, where, wanna, week, hire";

			correct = 1;
		}
		if (soal == 22) {
			soalNya.text = "manfaat membaca buku adalah";
			pilA.GetComponentInChildren<Text>().text = "sebagai hiburan semata";
			pilB.GetComponentInChildren<Text>().text = "agar dianggap kutu buku";
			pilC.GetComponentInChildren<Text>().text = "menambah wawasan dan pengetahuan";
			pilD.GetComponentInChildren<Text>().text = "supaya tidak dibilang kurang pergaulan";

			correct = 3;
		}
		if (soal == 23) {
			soalNya.text = "Rajin pangkal...";
			pilA.GetComponentInChildren<Text>().text = "Pandai";
			pilB.GetComponentInChildren<Text>().text = "Hebat";
			pilC.GetComponentInChildren<Text>().text = "Kaya";
			pilD.GetComponentInChildren<Text>().text = "Bersih";

			correct = 1;
		}
		if (soal == 24) {
			soalNya.text = "Tong kosong nyaring...";
			pilA.GetComponentInChildren<Text>().text = "Suaranya";
			pilB.GetComponentInChildren<Text>().text = "Teriakannya";
			pilC.GetComponentInChildren<Text>().text = "Bunyinya";
			pilD.GetComponentInChildren<Text>().text = "Lagunya";

			correct = 3;
		}
		if (soal == 25) {
			soalNya.text = "contoh pembukaan dalam pidato adalah";
			pilA.GetComponentInChildren<Text>().text = "selamat pagi teman-teman.";
			pilB.GetComponentInChildren<Text>().text = "cukup sekian dan terimakasih.";
			pilC.GetComponentInChildren<Text>().text = "kita harus menang dalam perlombaan itu.";
			pilD.GetComponentInChildren<Text>().text = "saya minta maaf jika kurang sopan.";

			correct = 1;
		}
		if (soal == 26) {
			soalNya.text = "aktual adalah...";
			pilA.GetComponentInChildren<Text>().text = "pembaca berita";
			pilB.GetComponentInChildren<Text>().text = "informasi";
			pilC.GetComponentInChildren<Text>().text = "peristiwa yang baru terjadi";
			pilD.GetComponentInChildren<Text>().text = "pidato";

			correct = 3;
		}
		if (soal == 27) {
			soalNya.text = "suatu peristiwa yang diinformasikan kepada masyarakat atau khalayak umum disebut?";
			pilA.GetComponentInChildren<Text>().text = "televisi";
			pilB.GetComponentInChildren<Text>().text = "berita";
			pilC.GetComponentInChildren<Text>().text = "komunikasi";
			pilD.GetComponentInChildren<Text>().text = "percakapan";

			correct = 2;
		}
		if (soal == 28) {
			soalNya.text = "suatu kegiatan berbicara di depan umum guna memberikan gambaran tentang suatu hal disebut?";
			pilA.GetComponentInChildren<Text>().text = "berita";
			pilB.GetComponentInChildren<Text>().text = "informasi";
			pilC.GetComponentInChildren<Text>().text = "pidato";
			pilD.GetComponentInChildren<Text>().text = "naskah";

			correct = 3;
		}
		if (soal == 29) {
			soalNya.text = "Penutup pidato biasanya berisi ";
			pilA.GetComponentInChildren<Text>().text = "harapan, pesan, salam penutup";
			pilB.GetComponentInChildren<Text>().text = "salam pembuka, ucapan terimakasih";
			pilC.GetComponentInChildren<Text>().text = "maksud, tujuan, sasaran";
			pilD.GetComponentInChildren<Text>().text = "pujian kepada orang yang lebih tua";

			correct = 1;
		}
		if (soal == 30) {
			soalNya.text = "makna yang tersembunyi di dalam suatu teks dinamakan?";
			pilA.GetComponentInChildren<Text>().text = "makna tersembunyi";
			pilB.GetComponentInChildren<Text>().text = "makna tersurat";
			pilC.GetComponentInChildren<Text>().text = "Makna tersirat";
			pilD.GetComponentInChildren<Text>().text = "makna terkandung ";

			correct = 3;
		}
		if (soal == 31) {
			soalNya.text = "kata hubung ketika digunakan bila peristiwa pertama dan kedua terjadi secara...";
			pilA.GetComponentInChildren<Text>().text = "sendiri-sendiri";
			pilB.GetComponentInChildren<Text>().text = "berbeda tempat";
			pilC.GetComponentInChildren<Text>().text = "bersamaan";
			pilD.GetComponentInChildren<Text>().text = "berlainan";

			correct = 3;
		}
		if (soal == 32) {
			soalNya.text = "drama biasanya dimainkan oleh dua tokoh, yakni tokoh utama dan tokoh?";
			pilA.GetComponentInChildren<Text>().text = "jahat";
			pilB.GetComponentInChildren<Text>().text = "pendukung";
			pilC.GetComponentInChildren<Text>().text = "baik";
			pilD.GetComponentInChildren<Text>().text = "figuran";

			correct = 2;
		}
		if (soal == 33) {
			soalNya.text = "sebuah buku menjadi baik jika ditulis oleh orang yang ... di bidangnya.";
			pilA.GetComponentInChildren<Text>().text = "ahli";
			pilB.GetComponentInChildren<Text>().text = "jauh";
			pilC.GetComponentInChildren<Text>().text = "dekat";
			pilD.GetComponentInChildren<Text>().text = "akrab";

			correct = 1;
		}
		if (soal == 34) {
			soalNya.text = "amanat drama dapat kita peroleh jika kita melakukan hal berikut, kecuali...";
			pilA.GetComponentInChildren<Text>().text = "membaca naskah drama";
			pilB.GetComponentInChildren<Text>().text = "menonton pertunjukan drama";
			pilC.GetComponentInChildren<Text>().text = "mendengar cerita naskah drama";
			pilD.GetComponentInChildren<Text>().text = "membeli tiket pertunjukan drama";

			correct = 4;
		}
		if (soal == 35) {
			soalNya.text = "manfaat membaca buku adalah...";
			pilA.GetComponentInChildren<Text>().text = "sebagai hiburan semata";
			pilB.GetComponentInChildren<Text>().text = "agar dianggap kutu buku";
			pilC.GetComponentInChildren<Text>().text = "menambah wawasan dan pengetahuan";
			pilD.GetComponentInChildren<Text>().text = "supaya tidak dibilang kurang pergaulan";

			correct = 3;
		}
		if (soal == 36) {
			soalNya.text = "sumber pidato berasal dari tiga hal berikut, kecuali...";
			pilA.GetComponentInChildren<Text>().text = "pengalaman";
			pilB.GetComponentInChildren<Text>().text = "penelitian";
			pilC.GetComponentInChildren<Text>().text = "pemikiran/imajinasi";
			pilD.GetComponentInChildren<Text>().text = "peniruan";

			correct = 4;
		}
		if (soal == 37) {
			soalNya.text = "Didin tidak masuk sekolah karena sakit. Kalimat itu merupakan kalimat majemuk bertingkat...";
			pilA.GetComponentInChildren<Text>().text = "hubungan sebab";
			pilB.GetComponentInChildren<Text>().text = "pengandaian";
			pilC.GetComponentInChildren<Text>().text = "perbandingan";
			pilD.GetComponentInChildren<Text>().text = "hubungan waktu";

			correct = 1;
		}
		if (soal == 38) {
			soalNya.text = "bunyi pantun pada akhir kalimat pertama sama dengan bunyi pantun pada baris...";
			pilA.GetComponentInChildren<Text>().text = "awal";
			pilB.GetComponentInChildren<Text>().text = "kedua";
			pilC.GetComponentInChildren<Text>().text = "ketiga";
			pilD.GetComponentInChildren<Text>().text = "keempat";

			correct = 3;
		}
		if (soal == 39) {
			soalNya.text = "Dalam membuat pengumuman, isi pengumuman harus...";
			pilA.GetComponentInChildren<Text>().text = "banyak dan panjang";
			pilB.GetComponentInChildren<Text>().text = "mudah dipahami";
			pilC.GetComponentInChildren<Text>().text = "padat, singkat, dan jelas";
			pilD.GetComponentInChildren<Text>().text = "singkat dan pendek";

			correct = 3;
		}
		if (soal == 40) {
			soalNya.text = "isi sebuah karangan dalam bentuk pantun ada pada...";
			pilA.GetComponentInChildren<Text>().text = "baris 1 dan 2";
			pilB.GetComponentInChildren<Text>().text = "baris 1 dan 3";
			pilC.GetComponentInChildren<Text>().text = "baris 3 dan 4";
			pilD.GetComponentInChildren<Text>().text = "baris 2 dan 4";

			correct = 3;
		}


		//Soal IPA
		if (soal == 41) {
			soalNya.text = "bebek dapat berenang karena memiliki ciri khusus, yaitu";
			pilA.GetComponentInChildren<Text>().text = "kaki berselaput";
			pilB.GetComponentInChildren<Text>().text = "bernafas menggunakan insang";
			pilC.GetComponentInChildren<Text>().text = "paruh berkantong";
			pilD.GetComponentInChildren<Text>().text = "dapat menyemprotkan tinta";

			correct = 1;
		}
		if (soal == 42) {
			soalNya.text = "unta menyimpan cadangan makanan di punuknya berupa";
			pilA.GetComponentInChildren<Text>().text = "lemak";
			pilB.GetComponentInChildren<Text>().text = "air";
			pilC.GetComponentInChildren<Text>().text = "protein";
			pilD.GetComponentInChildren<Text>().text = "mineral";

			correct = 1;
		}
		if (soal == 43) {
			soalNya.text = "hewan yang melakukan penyamaran sebagai usaha melindungi diri dari kejaran musuhnya, yaitu";
			pilA.GetComponentInChildren<Text>().text = "ular";
			pilB.GetComponentInChildren<Text>().text = "belalang";
			pilC.GetComponentInChildren<Text>().text = "bunglon";
			pilD.GetComponentInChildren<Text>().text = "kura-kura";

			correct = 3;
		}
		if (soal == 44) {
			soalNya.text = "hewan berikut yang termasuk mamalia air adalah";
			pilA.GetComponentInChildren<Text>().text = "kadal dan buaya";
			pilB.GetComponentInChildren<Text>().text = "paus dan pesut";
			pilC.GetComponentInChildren<Text>().text = "ikan tuna dan kura-kura";
			pilD.GetComponentInChildren<Text>().text = "ikan tuna dan lumba-lumba";

			correct = 2;
		}
		if (soal == 45) {
			soalNya.text = "pohon pisang berkembang biak dengan";
			pilA.GetComponentInChildren<Text>().text = "umbi batang";
			pilB.GetComponentInChildren<Text>().text = "umbi lapis";
			pilC.GetComponentInChildren<Text>().text = "tunas";
			pilD.GetComponentInChildren<Text>().text = "geragih";

			correct = 3;
		}
		if (soal == 46) {
			soalNya.text = "unta menyimpan cadangan makanan di punuknya berupa...";
			pilA.GetComponentInChildren<Text>().text = "lemak";
			pilB.GetComponentInChildren<Text>().text = "air";
			pilC.GetComponentInChildren<Text>().text = "protein";
			pilD.GetComponentInChildren<Text>().text = "mineral ";

			correct = 1;
		}
		if (soal == 47) {
			soalNya.text = "burung hantu mempunyai kelebihan dibandingkan dengan burung lain, yaitu...";
			pilA.GetComponentInChildren<Text>().text = "geraknya sangat cepat";
			pilB.GetComponentInChildren<Text>().text = "kemampuan melihat pada malam hari yang luar biasanya";
			pilC.GetComponentInChildren<Text>().text = "merupakan hewan yang aktif pada siang hari";
			pilD.GetComponentInChildren<Text>().text = "makanannya berupa buah-buahan ";

			correct = 2;
		}
		if (soal == 48) {
			soalNya.text = "hewan yang melakukan penyamaran sebagai usaha melindungi diri dari kejaran musuhnya, yaitu";
			pilA.GetComponentInChildren<Text>().text = "ular";
			pilB.GetComponentInChildren<Text>().text = "belalang";
			pilC.GetComponentInChildren<Text>().text = "bunglon";
			pilD.GetComponentInChildren<Text>().text = "kura-kura ";

			correct = 3;
		}
		if (soal == 49) {
			soalNya.text = "kelelawar memiliki sayap yang terbuat dari";
			pilA.GetComponentInChildren<Text>().text = "tulang yang keras";
			pilB.GetComponentInChildren<Text>().text = "kulit yang tipis";
			pilC.GetComponentInChildren<Text>().text = "bulu yang tebal";
			pilD.GetComponentInChildren<Text>().text = "tulang yang lunak ";

			correct = 2;
		}
		if (soal == 50) {
			soalNya.text = "cicak melindungi diri dari musuhnya dengan cara ";
			pilA.GetComponentInChildren<Text>().text = "mengubah warna kulitnya";
			pilB.GetComponentInChildren<Text>().text = "mengeluarkan bunyi yang keras";
			pilC.GetComponentInChildren<Text>().text = "memutuskan ekornya";
			pilD.GetComponentInChildren<Text>().text = "mengeluarkan bau tak sedap ";

			correct = 3;
		}
		if (soal == 51) {
			soalNya.text = "tumbuhan berikut yang menyesuaikan diri dengan lingkungan basah adalah";
			pilA.GetComponentInChildren<Text>().text = "teratai";
			pilB.GetComponentInChildren<Text>().text = "kaktus";
			pilC.GetComponentInChildren<Text>().text = "rambutan";
			pilD.GetComponentInChildren<Text>().text = "durian ";

			correct = 1;
		}
		if (soal == 52) {
			soalNya.text = "tumbuhan berikut yang menyesuaikan diri dengan lingkungan kering adalah";
			pilA.GetComponentInChildren<Text>().text = "teratai";
			pilB.GetComponentInChildren<Text>().text = "kaktus";
			pilC.GetComponentInChildren<Text>().text = "rambutan";
			pilD.GetComponentInChildren<Text>().text = "durian ";

			correct = 2;
		}
		if (soal == 53) {
			soalNya.text = "berkembang biak adalah kemampuan makhluk hidup";
			pilA.GetComponentInChildren<Text>().text = "memperbanyak diri";
			pilB.GetComponentInChildren<Text>().text = "menyesuaikan diri";
			pilC.GetComponentInChildren<Text>().text = "melindungi diri";
			pilD.GetComponentInChildren<Text>().text = "mempertahankan diri ";

			correct = 1;
		}
		if (soal == 54) {
			soalNya.text = "tujuan makhluk hidup berkembang biak adalah...";
			pilA.GetComponentInChildren<Text>().text = "melestarikan hidup";
			pilB.GetComponentInChildren<Text>().text = "menghasilkan keturunan";
			pilC.GetComponentInChildren<Text>().text = "melestarikan jenisnya";
			pilD.GetComponentInChildren<Text>().text = "mempertahankan makhluk hidup ";

			correct = 2;
		}
		if (soal == 55) {
			soalNya.text = "hewan berikut yang termasuk mamalia air adalah...";
			pilA.GetComponentInChildren<Text>().text = "kadal dan buaya";
			pilB.GetComponentInChildren<Text>().text = "paus dan pesut";
			pilC.GetComponentInChildren<Text>().text = "ikan tuna dan kura-kura";
			pilD.GetComponentInChildren<Text>().text = "ikan tuna dan lumba-lumba ";

			correct = 2;
		}
		if (soal == 56) {
			soalNya.text = "bagian ikan hiu yang dimanfaatkan untuk sup adalah";
			pilA.GetComponentInChildren<Text>().text = "ekornya";
			pilB.GetComponentInChildren<Text>().text = "siripnya";
			pilC.GetComponentInChildren<Text>().text = "dagingnya";
			pilD.GetComponentInChildren<Text>().text = "insangnya";

			correct = 2;
		}
		if (soal == 57) {
			soalNya.text = "punuk pada punggung unta berfungsi untuk ...";
			pilA.GetComponentInChildren<Text>().text = "menarik perhatian lawan jenisnya";
			pilB.GetComponentInChildren<Text>().text = "memperindah bentuk tubuhnya";
			pilC.GetComponentInChildren<Text>().text = "menyimpan makanan dalam bentuk lemak";
			pilD.GetComponentInChildren<Text>().text = "mengangkut barang yang berat";

			correct = 3;
		}
		if (soal == 58) {
			soalNya.text = "akibat buruk yang ditimbulkan oleh penebangan hutan secara liar adalah...";
			pilA.GetComponentInChildren<Text>().text = "tersedia air bersih";
			pilB.GetComponentInChildren<Text>().text = "banyak tersedia kayu";
			pilC.GetComponentInChildren<Text>().text = "harga kayu murah";
			pilD.GetComponentInChildren<Text>().text = "terjadi tanah longsong ";

			correct = 4;
		}
		if (soal == 59) {
			soalNya.text = "penanaman kembali tumbuhan yang ditebang disebut...";
			pilA.GetComponentInChildren<Text>().text = "reboisasi";
			pilB.GetComponentInChildren<Text>().text = "irigasi";
			pilC.GetComponentInChildren<Text>().text = "populasi";
			pilD.GetComponentInChildren<Text>().text = "penangkaran";

			correct = 1;
		}
		if (soal == 60) {
			soalNya.text = "hewan dibawah ini kulitnya bisa dijadikan pakaian, kecuali  ";
			pilA.GetComponentInChildren<Text>().text = "ular";
			pilB.GetComponentInChildren<Text>().text = "buaya";
			pilC.GetComponentInChildren<Text>().text = "harimau";
			pilD.GetComponentInChildren<Text>().text = "gajah ";

			correct = d;
		}

		//Soal IPS
		if (soal == 61) {
			soalNya.text = "Nama mata uang Indonesia adalah";
			pilA.GetComponentInChildren<Text>().text = "Dolar";
			pilB.GetComponentInChildren<Text>().text = "Ringgit";
			pilC.GetComponentInChildren<Text>().text = "Rupiah";
			pilD.GetComponentInChildren<Text>().text = "Rupe";

			correct = 3;
		}
		if (soal == 62) {
			soalNya.text = "Adiknya ayah yang laki-laki kita panggil";
			pilA.GetComponentInChildren<Text>().text = "Bibi";
			pilB.GetComponentInChildren<Text>().text = "Buyut";
			pilC.GetComponentInChildren<Text>().text = "Tante";
			pilD.GetComponentInChildren<Text>().text = "Paman";

			correct = 4;
		}
		if (soal == 63) {
			soalNya.text = "Apa nama tempat untuk pesawat terbang mendarat?";
			pilA.GetComponentInChildren<Text>().text = "Terminal";
			pilB.GetComponentInChildren<Text>().text = "Stasiun";
			pilC.GetComponentInChildren<Text>().text = "Bandara";
			pilD.GetComponentInChildren<Text>().text = "Pelabuhan";

			correct = 3;
		}
		if (soal == 64) {
			soalNya.text = "Kepala keluarga di rumah adalah";
			pilA.GetComponentInChildren<Text>().text = "Ayah";
			pilB.GetComponentInChildren<Text>().text = "Ibu";
			pilC.GetComponentInChildren<Text>().text = "Kakek";
			pilD.GetComponentInChildren<Text>().text = "Nenek";

			correct = 1;
		}
		if (soal == 65) {
			soalNya.text = "Arah antara barat dan utara adalah";
			pilA.GetComponentInChildren<Text>().text = "Timur Laut";
			pilB.GetComponentInChildren<Text>().text = "Tenggara";
			pilC.GetComponentInChildren<Text>().text = "Barat Laut";
			pilD.GetComponentInChildren<Text>().text = "Barat Daya";

			correct = 3;
		}
		if (soal == 66) {
			soalNya.text = "Dari kecil rajin menabung sudah besar akan...";
			pilA.GetComponentInChildren<Text>().text = "Rugi duitnya habis";
			pilB.GetComponentInChildren<Text>().text = "Beruntung";
			pilC.GetComponentInChildren<Text>().text = "Menyesal";
			pilD.GetComponentInChildren<Text>().text = "Bingung ";

			correct = 2;
		}
		if (soal == 67) {
			soalNya.text = "Ayah bekerja mencari nafkah untuk mmenuhi...";
			pilA.GetComponentInChildren<Text>().text = "Uang jajan anaknya";
			pilB.GetComponentInChildren<Text>().text = "Kebutuhan keluarga ";
			pilC.GetComponentInChildren<Text>().text = "Kebutuhan pribadi";
			pilD.GetComponentInChildren<Text>().text = "kebutuhan anak ";

			correct = 2;
		}
		if (soal == 68) {
			soalNya.text = "Sebagian penduduk desa bekerja sebagai";
			pilA.GetComponentInChildren<Text>().text = "Dokter";
			pilB.GetComponentInChildren<Text>().text = "Petani";
			pilC.GetComponentInChildren<Text>().text = "Polisi";
			pilD.GetComponentInChildren<Text>().text = "Pilot ";

			correct = 2;
		}
		if (soal == 69) {
			soalNya.text = "Anak nomor satu disebut juga anak ";
			pilA.GetComponentInChildren<Text>().text = "Semata wayang";
			pilB.GetComponentInChildren<Text>().text = "Sulung";
			pilC.GetComponentInChildren<Text>().text = "Bungsu";
			pilD.GetComponentInChildren<Text>().text = "bontot";

			correct = 3;
		}
		if (soal == 70) {
			soalNya.text = "Barter merupakan...";
			pilA.GetComponentInChildren<Text>().text = "Peminjam uang dengan uang";
			pilB.GetComponentInChildren<Text>().text = "Barang dan uang";
			pilC.GetComponentInChildren<Text>().text = "Tukar menukar barang dengan barang";
			pilD.GetComponentInChildren<Text>().text = "Peminjam barang";

			correct = 3;
		}
		if (soal == 71) {
			soalNya.text = "Fatma duduk di kelas III SD. Ia ingin membeli buku cerita dengan uangnya sendiri. Hal yang seharusnya ia lakukan adalah";
			pilA.GetComponentInChildren<Text>().text = "Meminjam uang ke teman";
			pilB.GetComponentInChildren<Text>().text = "Menabung";
			pilC.GetComponentInChildren<Text>().text = "Meminta ke orang lain";
			pilD.GetComponentInChildren<Text>().text = "Mengemis di jalan";

			correct = 2;
		}
		if (soal == 72) {
			soalNya.text = "Anak yang berbakti adalah anak yang patuh kepada...";
			pilA.GetComponentInChildren<Text>().text = "Ayah";
			pilB.GetComponentInChildren<Text>().text = "Orang tua";
			pilC.GetComponentInChildren<Text>().text = "Ibu";
			pilD.GetComponentInChildren<Text>().text = "adik";

			correct = 3;
		}
		if (soal == 73) {
			soalNya.text = "Sikap penjual yang baik ketika selesai menjual barang ialah...";
			pilA.GetComponentInChildren<Text>().text = "Berlalu begitu saja";
			pilB.GetComponentInChildren<Text>().text = "Mengucapkan terima kasih";
			pilC.GetComponentInChildren<Text>().text = "Menunjukan kelelahan";
			pilD.GetComponentInChildren<Text>().text = "Melempar barang dagangan";

			correct = 2;
		}
		if (soal == 74) {
			soalNya.text = "Pekerjaan orang tua tidak sama. Orang tua yang pekerjaannya bercocok tanam di sawah disebut...";
			pilA.GetComponentInChildren<Text>().text = "Petani";
			pilB.GetComponentInChildren<Text>().text = "Pedagang";
			pilC.GetComponentInChildren<Text>().text = "Nelayan";
			pilD.GetComponentInChildren<Text>().text = "Pelawak";

			correct = 1;
		}
		if (soal == 75) {
			soalNya.text = "Air sangat berguna bagi manusia tetapi dapat menjadi bencana jika terjadi...";
			pilA.GetComponentInChildren<Text>().text = "Gempa bumi";
			pilB.GetComponentInChildren<Text>().text = "Longsor";
			pilC.GetComponentInChildren<Text>().text = "Banjir";
			pilD.GetComponentInChildren<Text>().text = "Kekeringan ";

			correct = 3;
		}
		if (soal == 76) {
			soalNya.text = "Gambar yang	menunjukan letak suatu tempat disebut...";
			pilA.GetComponentInChildren<Text>().text = "Peta";
			pilB.GetComponentInChildren<Text>().text = "Atlas";
			pilC.GetComponentInChildren<Text>().text = "Denah";
			pilD.GetComponentInChildren<Text>().text = "Arah angin ";

			correct = 1;
		}
		if (soal == 77) {
			soalNya.text = "Bersama – sama membangun poskamling merupakan bentuk kerja sama di lingkungan...";
			pilA.GetComponentInChildren<Text>().text = "Masyarakat";
			pilB.GetComponentInChildren<Text>().text = "Keluarga";
			pilC.GetComponentInChildren<Text>().text = "Sekolah";
			pilD.GetComponentInChildren<Text>().text = "Kerja ";

			correct = 1;
		}
		if (soal == 78) {
			soalNya.text = "Sesama anggota keluarga harus saling...";
			pilA.GetComponentInChildren<Text>().text = "Menghormati";
			pilB.GetComponentInChildren<Text>().text = "Bertengkar";
			pilC.GetComponentInChildren<Text>().text = "Bermusuhan";
			pilD.GetComponentInChildren<Text>().text = "Menyalahi";

			correct = 1;
		}
		if (soal == 79) {
			soalNya.text = "Pesawat terbang mendarat di...";
			pilA.GetComponentInChildren<Text>().text = "Bandara";
			pilB.GetComponentInChildren<Text>().text = "Terminal";
			pilC.GetComponentInChildren<Text>().text = "Stasiun";
			pilD.GetComponentInChildren<Text>().text = "Pelabuhan";

			correct = 1;
		}
		if (soal == 80) {
			soalNya.text = "Alat yang berguna untuk menunjukkan arah disebut...";
			pilA.GetComponentInChildren<Text>().text = "Stopwatch";
			pilB.GetComponentInChildren<Text>().text = "Kompas";
			pilC.GetComponentInChildren<Text>().text = "Seismograf";
			pilD.GetComponentInChildren<Text>().text = "Atlas ";

			correct = 2;
		}

	}

	public void Answering(int ans){
		if (ans == 1) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 2) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 3) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
		if (ans == 4) {
			if (ans == correct) {
				//benar
				print("benar");
				if (GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isfinal) {
					YouWin.SetActive (true);
				} else {
					GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveNextBenarJawab ();
				}
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore += 10;
			} else {
				//salah
				print("salah");
				//GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().currentPos -= GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().getDadu;
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().moveBackSalahJawab();
				GameObject.Find ("PlayerPrototype").GetComponent<PlayerController> ().isQuiz = false;
				QuizTime.SetActive (false);
				yourScore -= 5;
			}
		}
	}
}
