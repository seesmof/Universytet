n=19


o.vector=9:19
t.vector=7:17
cor(o.vector,t.vector)

g.vector=-3*o.vector+sample(1:19,1)
cor(o.vector,g.vector)


year=sample(2000:2024,n,replace=T)
rate=sample(1:10,n,replace=T)
plot(year,rate,main='Процентна ставка')

cor(year,rate)


o=sample(n,replace=T)
t=sample(n,replace=T)

print(cor.test(o,t,use='complete.obs'))
p.lm=lm(formula=t~o)
print(summary(p.lm))
plot(o,t)
abline(lm(t~o))