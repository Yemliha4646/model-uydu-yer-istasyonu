# Model Uydu Yer İstasyonu Arayüzü (Model Satellite Ground Station UI)

Bu proje, model uydulardan (can-sat / telemetry satellites) gelen anlık verileri seri port (COM) üzerinden almak, görselleştirmek, kaydetmek ve analiz etmek amacıyla **C# Windows Forms (.NET Framework 4.7.2)** ile geliştirilmiş gelişmiş bir yer istasyonu yazılımıdır. 

Yazılım; özellikle **TEKNOFEST Model Uydu Yarışması** standartlarına ve gereksinimlerine uygun olarak tasarlanmış olup, 3D yönelim görselleştirmesinden GPS takibine, gerçek zamanlı grafiklerden kamera kaydına kadar birçok kritik yer istasyonu özelliğini barındırır.

---

## 🚀 Proje Versiyonları

Proje dizininde iki farklı geliştirme aşamasına ait klasör bulunmaktadır:
1. **`Ground Station UI v4` (Güncel & Gelişmiş Versiyon)**: 
   * OpenGL/OpenTK ile 3D model yönelim görselleştirmesi.
   * GMap.NET ile GPS konumunun harita üzerinde anlık takibi.
   * AForge ve Accord.Video.FFMPEG entegrasyonu ile canlı kamera akışı ve video kaydı.
   * LiveCharts ve MS Charting ile gerçek zamanlı telemetri grafikleri.
   * Otomatik COM port algılama ve kopan bağlantıyı otomatik geri yükleme mekanizması.
   * Hata kodlarını ve uçuş aşamalarını (Uçuşa Hazır, Yükselme, Model İniş, Ayrılma, Görev Yükü İniş, Kurtarma) görsel göstergelerle takip etme.
2. **`Ground Station UI 2` (Temel/Prototip Versiyon)**:
   * Temel telemetri okuma, seri port kontrolü ve CSV kaydı yapan daha sade bir ilk aşama sürümüdür.

---

## 📊 Telemetri Veri Paketi Yapısı (Telemetry Protocol)

Yer istasyonuna gelen ham telemetri verileri virgülle ayrılmış (**CSV**) formatta olup, 22 parametreden oluşur. `TelemetryProcessor` sınıfı bu verileri şu şekilde çözümler:

| İndis | Değişken Adı | Açıklama |
| :---: | :--- | :--- |
| **0** | `PacketNumber` | Paket Numarası |
| **1** | `SatelliteStatus` | Uydu Uçuş Statüsü (0-5 Arası Aşama Kodu) |
| **2** | `ErrorCode` | 6-Bit İkili (Binary) Hata Kodu (Örn: `000000`) |
| **3** | `SendTime` | Gönderme Zamanı / Saat |
| **4** | `Pressure1` | Basınç 1 |
| **5** | `Pressure2` | Basınç 2 |
| **6** | `Altitude1` | İrtifa 1 |
| **7** | `Altitude2` | İrtifa 2 |
| **8** | `AltitudeDifference` | İrtifa Farkı |
| **9** | `DescentSpeed` | İniş Hızı |
| **10**| `Temperature` | Sıcaklık |
| **11**| `BatteryVoltage` | Pil Gerilimi |
| **12**| `Gps1Latitude` | GPS 1 Enlem (Ham değer / 1e6) |
| **13**| `Gps1Longitude` | GPS 1 Boylam (Ham değer / 1e6) |
| **14**| `Gps1Altitude` | GPS 1 İrtifa |
| **15**| `Pitch` | Yunuslama Açısı (Jiroskop X Ekseni) |
| **16**| `Roll` | Yalpalama Açısı (Jiroskop Y Ekseni) |
| **17**| `Yaw` | Sapma Açısı (Jiroskop Z Ekseni) |
| **18**| `RHRH` | RHRH Tanımlayıcı Veri |
| **19**| `IoTData1` | IoT Verisi 1 |
| **20**| `IoTData2` | IoT Verisi 2 |
| **21**| `TeamNumber` | Takım Numarası |

---

## ✨ Temel Özellikler (Key Features)

### 1. 3D Yönelim Simülasyonu (3D Attitude Visualization)
* **OpenTK (OpenGL)** arayüzü kullanılarak uydunun uzaydaki yönelimi (Pitch, Roll, Yaw) 3 boyutlu bir silindir model üzerinden gerçek zamanlı olarak simüle edilir. 

### 2. Harita Üzerinde GPS Takibi (GPS Tracking Map)
* **GMap.NET** kütüphanesi yardımıyla uydudan gelen enlem ve boylam verileri çözümlenerek harita üzerinde anlık konum işaretlenir ve takip edilir.

### 3. Gerçek Zamanlı Grafikler (Real-time Charts)
* Sıcaklık, İrtifa (İrtifa 1, İrtifa 2, İrtifa Farkı) ve Basınç verileri anlık olarak çizdirilir.

### 4. Kamera Yönetimi ve Video Kaydı (Camera & Video Recording)
* **AForge.Video.DirectShow** ile bilgisayara bağlı kameralar taranıp seçilebilir.
* **Accord.Video.FFMPEG** kütüphanesi yardımıyla gelen kamera görüntüsü yerel diskteki bir `.mp4`/`.avi` dosyasına yüksek performanslı olarak kaydedilebilir.

### 5. Hata Takip Sistemi (Error Monitoring Ledger)
Uydunun gönderdiği 6-bitlik hata kodu (`ErrorCode`) çözümlenerek arayüzdeki kırmızı/yeşil LED durum göstergeleri güncellenir ve ilgili hata mesajları listelenir:
* **1. Hata:** Model iniş hızı anormal
* **2. Hata:** Görev yükü iniş hızı anormal
* **3. Hata:** Taşıyıcı basınç verisi yok
* **4. Hata:** Görev yükü konum verisi yok
* **5. Hata:** Ayrılma gerçekleşmedi
* **6. Hata:** Multi-spektral filtre çalışmıyor

### 6. Uçuş Durumu İlerleme Çubuğu (Flight Stage Progress)
Uydunun durum kodu çözümlenerek uçuşun hangi aşamada olduğu progress bar ve aktifleşen kalın yazı etiketleriyle takip edilir:
* `Uçuşa Hazır` ➔ `Yükselme` ➔ `Model İniş` ➔ `Ayrılma` ➔ `Görev Yükü İniş` ➔ `Kurtarma`

---

## 🛠️ Sistem Gereksinimleri ve Bağımlılıklar

Projenin derlenmesi ve çalıştırılması için aşağıdaki gereksinimlerin karşılanması gerekir:

* **İşletim Sistemi:** Windows
* **IDE:** Visual Studio (2019 veya üzeri önerilir)
* **Framework:** .NET Framework 4.7.2
* **NuGet Paketleri & Kitaplıklar:**
  * **OpenTK & OpenTK.GLControl** (v3.3.3) - OpenGL Grafik Motoru
  * **AForge & AForge.Video.DirectShow** (v2.2.5) - Kamera Aygıt Yönetimi
  * **Accord & Accord.Video.FFMPEG** (v3.8.0) - Video Kodlama ve Kayıt
  * **GMap.NET.WinForms** (v2.1.7) - Harita Entegrasyonu
  * **LiveCharts.WinForms** (v0.9.7.1) - Gelişmiş Grafik Çizimi
  * **System.Data.SQLite** (v1.0.119.0) - GMap Harita Önbellek Yönetimi
  * **Newtonsoft.Json** (v13.0.3) - Veri formatlama ve konfigürasyonlar

---

## 💻 Kurulum ve Derleme (Installation & Setup)

1. Bu depoyu yerel bilgisayarınıza indirin veya klonlayın.
2. Visual Studio uygulamasını açın ve dosya menüsünden `Ground Station UI v4\Ground Station UI.sln` çözüm dosyasını seçin.
3. Proje açıldıktan sonra NuGet paketlerinin otomatik yüklenmesi için **Çözüm Gezgini (Solution Explorer)** üzerinde sağ tıklayıp **NuGet Paketlerini Geri Yükle (Restore NuGet Packages)** seçeneğini işaretleyin.
4. **Çözümü Derleyin (Build Solution)**. FFMPEG DLL dosyalarının ve SQLite bağımlılıklarının çıktı dizinine (`bin/Debug` veya `bin/Release`) kopyalandığından emin olun.
5. `Başlat (Start)` veya `F5` tuşuna basarak yer istasyonunu çalıştırabilirsiniz.

---

## 🛠️ Kullanım Rehberi (How to Use)

1. **Bağlantı Kurma:**
   * Arayüzün sağ/üst kısmında bulunan seri port seçim menüsünden uydunuzun bağlı olduğu COM portunu seçin.
   * Baudrate varsayılan olarak **115200** olarak sabitlenmiştir.
   * `Bağlan` butonuna basarak seri okumayı başlatın.
2. **Kamera Akışı:**
   * Bağlı kameralar listesinden ilgili kamerayı seçin ve canlı görüntüyü başlatın.
   * İsteğe bağlı olarak video kaydı için dosya yolu belirleyip kaydetme işlemini tetikleyebilirsiniz.
3. **Telemetri Kaydı:**
   * `Telemetri Dosyası Seç` menüsünden gelen ham verilerin yazılacağı bir `.csv` dosyası oluşturun/seçin. Veriler bu dosyaya otomatik olarak anlık olarak yazılacaktır.
4. **Hataları İzleme:**
   * Hata kodları listesinden yeşil yanan modüllerin sağlıklı, kırmızı yanan modüllerin ise hatalı çalıştığını izleyebilirsiniz. Hataların detayları alt kısımdaki hata paneline düşmektedir.
