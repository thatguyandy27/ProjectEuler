//
//  Problem62.cpp
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/10/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#include "Problem62.h"

#include <iostream>

using namespace std;


long long find_largest_permutation(long long val){
    int counts[10] = {};
    int remainder;
    
    while(val > 0){
        remainder = val % 10;
        val /= 10;
        counts[remainder]++;
    }
    
    long long new_val = 0;
    for (int i = 9; i >= 0; i--) {
        while(counts[i] > 0){
            new_val = new_val * 10 + i;
            counts[i]--;
        }
    }
    
    return new_val;
}

void Problem62::generate_answer(){
    
    //long long num = 112233445566778899;
    long long current_num = 345;
    bool not_found = true;
    
    while (not_found){
        long long result = current_num * current_num * current_num;
        long long max_permutation = find_largest_permutation(result);
        
        if(table.find(max_permutation) == table.end()){
            Problem62Data newData;
            newData.count = 0;
            newData.min_value = current_num;
            table[max_permutation] = newData;
        }
        
        table[max_permutation].count++;
        
        if(table[max_permutation].count == 5){
            not_found = false;
            cout << "The value to find is " << table[max_permutation].min_value << endl;
        }
        
        current_num++;
    }
    
    
    //    cout<< "Permutation for: " << num << " is " << find_largest_permutation(num) <<endl;
}