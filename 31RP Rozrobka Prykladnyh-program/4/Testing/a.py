REVELATION_22_UKRK='''
Одкриттє 22:1 І показав менї чисту ріку води життя, ясну як хришталь, що виходила з престола Божого і Агнцевого.
Одкриттє 22:2 А посеред улицї його, та й по сей і по той бік ріки - дерево життя, що родить овощі дванайцять (раз), і що місяця свій овощ дає, а листє з дерева на сцїленнє поган.
Одкриттє 22:3 І вже більш не буде жодного проклону; а престол Бога і Агнця буде в ньому, і слуги Його служити муть Йому.
Одкриттє 22:4 І побачять лице Його, а імя Його на чолах їх.
Одкриттє 22:5 І ночі не буде там; і не потрібувати муть сьвічника і сьвітла сонця, бо Господь Бог осьвічує їх; і царювати муть по вічні віки.
Одкриттє 22:6 І рече менї: Сї слова вірні і правдиві; і Господь, Бог сьвятих пророків, післав ангела свого, показати слугам своїм, що має незабаром бути.
Одкриттє 22:7 Ось прийду незабаром. Блаженний, хто хоронить слова пророцтва книги сієї.
Одкриттє 22:8 А я Йоан, що бачив се і чув; і коли чув я, і бачив, упав я поклонитись перед ногами ангела, що менї се показував.
Одкриттє 22:9 І каже менї: нї, глянь, я бо слуга-товариш твій, і братів твоїх пророків, і тих, що хоронять слова книги сієї: Богу поклони ся.
Одкриттє 22:10 І глаголе менї: Не печатай слів пророцтва книги сієї; час бо близько.
Одкриттє 22:11 Хто з'обіжає, нехай ще з'обіжає, і хто поганий, нехай ще опоганюєть ся; і хто праведний, нехай ще оправдуєть ся, і хто сьвятий, нехай ще осьвячуєть ся.
Одкриттє 22:12 І ось, я прийду хутко, і заплата моя зо мною, щоб віддати кожному, яко ж буде дїло його.
Одкриттє 22:13 Я Альфа і Омега, почин і конець, Первий і Останнїй.
Одкриттє 22:14 Блаженні, що творять заповідї Його, щоб мали власть до дерева життя, і увійшли ворітьми в город.
Одкриттє 22:15 А на дворі будуть пси, і чарівники, і перелюбники, і душегубцї, і ідолські служителї, і кожен, хто любить і робить лож.
Одкриттє 22:16 Я Ісус післав ангела мого, сьвідкувати вам усе по церквах. Я - корінь і рід Давидів, зоря ясна і рання.
Одкриттє 22:17 А Дух і невіста глаголють: Прийди! і хто чує, нехай каже: Прийди! Хто жадний, нехай прийде, а хто хоче, нехай приймає воду життя дармо.
Одкриттє 22:18 Сьвідкую ж також кожному, хто слухає словес пророцтва книги сієї: коли хто доложить до сього, доложить йому Бог і пораз, що написані в книзї сїй.
Одкриттє 22:19 Коли ж хто уйме від словес книги пророцтва сього, уйме Бог часть його з книги життя, і з города сьвятого, та й з того, що написано в книзї сїй.
Одкриттє 22:20 Сей, що про се сьвідкує, глаголе: Так, прийду хутко! Амінь. О, прийди, Господи Ісусе!
Одкриттє 22:21 Благодать Господа нашого Ісуса Христа з усїма вами. Амінь.
'''

import nltk
words=nltk.word_tokenize(REVELATION_22_UKRK.replace('\n',' ').strip())
print(words)