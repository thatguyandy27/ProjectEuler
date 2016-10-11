//
//  Problem65.cpp
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/11/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#include "Problem65.h"

#include <iostream>
#include "BigInteger.h"

using namespace std;

int sum_digits(BigInteger val){
    int total = 0;
    while(val > 0){
        
        total += (val % 10).getAsNumber();
        val /= 10;
    }
    
    return total;
}


void Problem65::generate_answer(){
    BigInteger n1 = 2,
        n2 = 3;
    
    int max = 100,
        index = 3;
    
    while(index <= max){
        BigInteger temp = n1;
        n1 = n2;
        
        BigInteger variable = index % 3 == 0 ? 2 * (index  / 3) : 1;
        
        n2 = n1 * variable + temp;
        
        index++;
    }
    
    cout<<"The final answer is: " << sum_digits(n2) << endl;
    
}