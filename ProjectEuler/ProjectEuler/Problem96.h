//
//  Problem96.hpp
//  ProjectEuler
//
//  Created by Andy Meyers on 1/28/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#ifndef Problem96_h
#define Problem96_h

#include <stdio.h>
#include <list>
#include <iostream>
#include <fstream>
#include <vector>
#include <string>

class ValidMoves{
    public:
    ValidMoves(int _x, int _y){
        this -> x = _x;
        this -> y = _y;
    }
    int x;
    int y;
    std::vector<int> moves;
};

class SodukuGame{
    public:
    SodukuGame(std::vector<std::vector<int>> prows){
        this->rows = prows;
    }
    void solve_puzzle();
    int get_solution();
    void print();
    void make_move(int val, int x, int y){
        rows[y][x] = val;
//        print();
    }
    bool is_solved();
    bool is_valid() { return _is_valid;}
    
    private:
    std::vector<std::vector<int>> rows;
    bool is_move_valid(int, int, int, const std::vector<std::vector<int>>&);
    std::vector<ValidMoves> get_valid_moves();
    
    bool _is_valid = true;
};

class Problem96{
    public:
    void generate_answer();
    
    private:
    long sum;
    std::list<SodukuGame> read_file(std::string);
    SodukuGame solve_puzzle(SodukuGame);
};



#endif /* Problem96_h */
