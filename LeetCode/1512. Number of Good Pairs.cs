public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        
        int count = 0;
        
        for(int i=0 ; i<nums.Length-1 ; i++){
            for(int j=i+1 ; j<nums.Length ; j++){
                if(nums[i]==nums[j]) count++;
            }
        }
        
        return count;
    }
}