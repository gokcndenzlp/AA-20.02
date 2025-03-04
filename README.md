# AA-20.02
Kth Eleman Bulma ve Bubble Sort Karşılaştırması
Bu proje, rastgele üretilen bir dizide k'ncı küçük elemanı bulma ve Bubble Sort ile sıralama süresini ölçme işlemlerini gerçekleştirir.

📌 Algoritma Açıklamaları
K'ncı Küçük Elemanı Bulma Algoritmaları
Bu algoritmalar, verilen bir dizide k'ncı küçük elemanı belirlemek için farklı yöntemler kullanır:

Sıralama Yöntemi (FindKthElement_Sort)
Diziyi tamamen sıralayıp, k-1 indeksindeki elemanı döndürür. Basit ve anlaşılır bir yöntemdir ancak büyük dizilerde zaman maliyeti yüksektir (O(n log n)).

Eklemeli Sıralama Yöntemi (FindKthElement_Insertion)
İlk k eleman küçük bir diziye alınır ve sıralanır. Daha sonra dizinin geri kalan elemanlarıyla kıyaslanarak gerektiğinde güncellenir. Bu yöntem, gereksiz sıralamaları önleyerek daha iyi performans sağlayabilir.

Bubble Sort Algoritması
Bubble Sort, diziyi sıralamak için kullanılan en temel algoritmalardan biridir. Elemanları ardışık olarak karşılaştırır ve sıralama sağlanana kadar değişim yapar. Küçük veri kümeleri için anlaşılır bir çözüm sunar ancak büyük veri setlerinde verimsizdir (O(n²)).

📊 Performans Karşılaştırması
Algoritmalar, farklı boyutlardaki diziler üzerinde test edilerek çalışma süreleri karşılaştırılır. Daha hızlı bir yöntem belirlemek için zaman ölçümleri yapılır ve analiz edilir.
