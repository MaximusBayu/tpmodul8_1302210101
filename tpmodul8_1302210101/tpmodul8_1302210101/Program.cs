// See https://aka.ms/new-console-template for more information

using static tpmodul8_1302210101.CovidConfig;

readWrite rw = new readWrite();


Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + rw.config.satuan_suhu);
double suhu = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
int hari = Convert.ToInt32(Console.ReadLine());

if ((rw.config.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) && hari < rw.config.batas_hari_demam){
    Console.WriteLine(rw.config.pesan_diterima);
}else if ((rw.config.satuan_suhu == "farenheit") && suhu >= 97.7 && suhu <= 99.5 && hari < rw.config.batas_hari_demam){
    Console.WriteLine(rw.config.pesan_diterima);
}else{
    Console.WriteLine(rw.config.pesan_ditolak);
}