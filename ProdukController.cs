using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TokoAPI.Controllers
{
    [ApiController]
    [Route("hai")]
    public class ProdukController : ControllerBase
    {
        public string Index()
        {
            return "Hello, welocme to my API!";
        }

        [HttpGet("hai")]

        public string Hai([FromQuery] string nama)

        {
            return "Hello, " + nama + "!";
        }

        [HttpGet("api/jsontest/produk-summary")]
        public object ProductSummary()
        {
            return new
            {
                jumlahproduk = "25",
                rataRataHarga = "10000",
                produkTertinggi = new
                {
                    id = "8",
                    nama = "Kabel HDMI",
                    harga = "7500"
                },
                produkTerendah = new
                {
                    id = "7",
                    nama = "Pisang",
                    harga = "3000"
                }
            };
        }

        [HttpGet("api/jsontest/produk-grouped")]
        public object ProductGrouped()
        {
            return new
            {
                Elektronik = new object[]
                {
                    new { id = "1", nama = "keyboard"},
                    new { id = "2", nama = "mouse" }
                },
                ATK = new object[]
                {
                    new { id = "3", nama = "buku"},
                    new { id = "4", nama = "pulpen"}
                }
            };
        }
        [HttpGet("api/jsontest/summary")]
        public object Summary()
        {
            return new
            {
                totalProduk = "17",
                rataRataHarga = "10000",
                produkTermahal = new
                {
                    id = "4",
                    nama = "Laptop",
                    harga = "7500000"
                },
                produkTermurah = new
                {
                    id = "1",
                    nama = "Pisang",
                    harga = "3000"
                },
                DaftarProduk = new object[]
                {
                    new { id = "1", nama = "Pensil"},
                    new { id = "2", nama = "Buku"}
                }
            };
        }
    }
}

