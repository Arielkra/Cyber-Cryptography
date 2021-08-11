/*
ilan tal 312201619
ariel kravizki 039678024
guy cohen 313189466
*/
#include<stdlib.h>
#include<math.h>
#include<time.h>
#include<stdio.h>


int gcd(int a, int b) {
	int temp;
	while (1) {
		temp = a % b;
		if (temp == 0)
			return b;
		a = b;
		b = temp;
	}
}


int main() {
	srand(time(NULL));
	int arr[] = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89 ,97 };//all prime numbers 25 in total
	int	p = rand() % 25;
	int  q = rand() % 25;
	while (q == p)// same prime number
	{
		int  q = rand() % 25;
	}
	p = arr[p];//take prime number from the array 
	q = arr[q];
	double n = p * q;// n=p*q
	double phi = (p - 1)*(q - 1);//phi
	//  1 < e < phi and gcd(e, phi) = 1
	double  e = 3;
	while (e < phi) {
		if (gcd(e, phi) == 1)
			break;
		else
			e++;
	}
	//d ≡ e−1 mod phi
	double d = fmod(1 / e, phi);
	//random massage
	double message = rand() % 100 + 1;
	//c Eccrypted
	double c = pow(message, e);
	//m Decrypted
	double m = pow(c, d);
	c = fmod(c, n);
	m = fmod(m, n);
	printf("Original=%3.lf\n", message);
	printf("p=%d\n", p);
	printf("q=%d\n", q);
	printf("n=%3.lf\n", n);
	printf("phi=%3.lf\n", phi);
	printf("e=%3.lf\n", e);
	printf("d=%lf\n", d);
	printf("Eccrypted=%3.lf\n", c);
	printf("Decrypted=%3.lf\n", m);

	getchar();
	return 0;
}