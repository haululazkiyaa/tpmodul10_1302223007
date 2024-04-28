namespace tpmodul10_1302223007
{
	public class Mahasiswa
	{
        public string nama { set; get; }
        public string nim { set; get; }

        public Mahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
        }
    }
}

