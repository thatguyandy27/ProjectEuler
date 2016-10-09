//
//  Problem81.cpp
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/7/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#include "Problem81.h"
#include <iostream>
#include <string>
#include <fstream>
#include <sstream>
#include <algorithm>
#include <climits>

using namespace std;

vector<vector<int>> get_test_data(){
    vector<vector<int>> ret;
    vector<int> row1;
    vector<int> row2;
    vector<int> row3;
    vector<int> row4;
    vector<int> row5;
    
    row1.push_back(131);
    row1.push_back(673);
    row1.push_back(234);
    row1.push_back(103);
    row1.push_back(18);
    
    row2.push_back(201);
    row2.push_back(96);
    row2.push_back(342);
    row2.push_back(965);
    row2.push_back(150);
    
    row3.push_back(630);
    row3.push_back(803);
    row3.push_back(746);
    row3.push_back(422);
    row3.push_back(111);

    row4.push_back(537);
    row4.push_back(699);
    row4.push_back(497);
    row4.push_back(121);
    row4.push_back(956);

    row5.push_back(805);
    row5.push_back(732);
    row5.push_back(524);
    row5.push_back(37);
    row5.push_back(331);
    
    ret.push_back(row1);
    ret.push_back(row2);
    ret.push_back(row3);
    ret.push_back(row4);
    ret.push_back(row5);
    
    return ret;
}


void Problem81::generate_answer(){
    //table = get_test_data();
    load_data();
    
    min_value = -1;
    
    vector<vector<int>>::size_type y = 0;
    
    while(y < table.size()){
        vector<int>new_row = vector<int>(table[0].size(), 0);
        table_cache.push_back(new_row);
        
        y++;
    }
    
    min_value = get_total();
    
    
    cout << "The min value is: " << min_value;

}

int Problem81::get_total(){
    static vector<vector<int>>::size_type  max_y = table.size();
    static vector<int>::size_type max_x = table[0].size();
    
    for(vector<vector<int>>::size_type y = table.size(); y --> 0;)
    {
        for(vector<int>::size_type x = table[y].size(); x --> 0;)
        {
            int bottom_min = INT_MAX,
                right_min = INT_MAX;
            if(y + 1 < max_y){
                bottom_min = table_cache[y + 1][x];
            }
            if(x + 1 < max_x){
                right_min = table_cache[y][x + 1];
            }
            if (bottom_min == INT_MAX && right_min == INT_MAX){
                bottom_min = 0;
            }
            int total = table_cache[y][x] = table[y][x] + min(bottom_min, right_min);
            cout<< total << endl;
        }
    }
    
    return table_cache[0][0];
}

int Problem81::get_total(vector<vector<int>>::size_type y, vector<int>::size_type x, int current_total){
    static vector<vector<int>>::size_type  max_y = table.size() - 1;
    static vector<int>::size_type max_x = table[0].size() - 1;
    
    int current_value = table[y][x],
        right_total = -1,
        bottom_total = -1;
    
    current_total += current_value;
    
    if(y == max_y && x == max_x ){
        if (current_total < min_value || min_value == -1){
            min_value = current_total;
        }
        
        return table[y][x];
    }
    
    // if we already found min for that node we can just return cache value
    if(table_cache[y][x] != 0){
        current_total = table_cache[y][x] + current_total;
        if (current_total < min_value || min_value == -1){
            min_value = current_total;
        }
        
        return table_cache[y][x];
    }

    
    
    if (x < max_x){
        right_total = get_total(y, x + 1, current_total);
    }
    if( y < max_y){
        bottom_total = get_total(y + 1, x, current_total);
    }
    
    
    // if bottom total is less & not negative then it is min for node
    if(bottom_total > 0 && bottom_total < right_total){
        table_cache[y][x] = bottom_total + current_value;
    }
    else{
        table_cache[y][x] = right_total + current_value;
    }
    
    return table_cache[y][x];
}

void Problem81::load_data(){
    static string FILE_NAME = "/Users/ameyers/github/ProjectEuler/ProjectEuler/ProjectEuler/p81data.txt";
    string line;
    ifstream myfile(FILE_NAME);
    while (getline( myfile, line )){
        vector<int> vect;
        
        stringstream ss(line);
        
        int i;
        
        while (ss >> i)
        {
            vect.push_back(i);
            
            if (ss.peek() == ',')
                ss.ignore();
        }
        
        table.push_back(vect);
    }
}

